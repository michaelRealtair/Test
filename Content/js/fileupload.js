(function () {

    var initUploaders = function () {

        // Images larger than 15MB will be rejected.
        var max_upload_size = 15 * 1024 * 1024; // 15MB

        // This is the approximate size of the longest edge of an uploaded image after processing.
        // Note that the exact size is a function of the original size. We enforce integer-factor reduction
        // scales because most clients are optimized for resizing under those conditions.
        var max_image_side = 1920; // Client-side image resizing

        // JPEG quality of the generated data URIs.
        var resized_image_quality = 0.92;

        // Largest number of files that can be added at once. Recommend setting this
        // fairly low to avoid abuse (although it will probably kill the client browser
        // before becoming a server issue).
        var max_allowed_files = 10;


        // Using a static counter guarantees uniqueness within a single session.
        var uid = function () {
            if (typeof this.ctr === 'undefined') this.ctr = parseInt(Math.random() * 9e9);
            else this.ctr++;
            return this.ctr.toString(36);
        };

        // Determines the closest integer-factor reduction for a given image. Leaves the image unchanged if the input size is smaller than
        // the desired output size.
        var calcSize = function (imagewidth, imageheight, longside_length) {
            var maxratio = Math.max(imagewidth / longside_length, imageheight / longside_length);
            return (maxratio > 1) ? { w: Math.floor(imagewidth / maxratio), h: Math.floor(imageheight / maxratio) } : { w: imagewidth, h: imageheight };
        };

        // Uses a canvas element to resize the image. Should work on most modern browsers, but
        // old IE support could be a problem.
        var resizeImage = function (img, orientation, longside_length, type) {
            var typemap = {
                'image/jpeg': 'image/jpeg',
                'image/png': 'image/png',
                'image/gif': 'image/png'		/* Most platforms do not support GIF output, so we map it to PNG instad to preserve alpha. */
            };

            var dimensions = calcSize(img.width, img.height, longside_length);

            var w = dimensions.w;
            var h = dimensions.h;

            if (orientation === 6 || orientation === 8) {
                console.log('swap');
                w = dimensions.h;
                h = dimensions.w;
            }

            var c = document.createElement('canvas');
            var cx = c.getContext('2d');
            c.width = w;
            c.height = h;

            if (orientation === 6) {
                console.log(666);
                cx.translate(w, 0);
                cx.rotate(90 * 1 * (Math.PI / 180));
            } else if (orientation === 3) {
                console.log(333);
                cx.translate(w, h);
                cx.rotate(90 * 2 * (Math.PI / 180));
            } else if (orientation === 8) {
                console.log(888);
                cx.translate(0, h);
                cx.rotate(90 * 3 * (Math.PI / 180));
            }

            console.log(orientation, w, h);

            cx.drawImage(img, 0, 0, dimensions.w, dimensions.h);

            console.log(typemap[type] || 'image/jpeg');
            return c.toDataURL(typemap[type] || 'image/jpeg', resized_image_quality || 0.8);

        };

        $('.attachment-upload>input[type="file"]').change(function () {

            $this = $(this);

            // Not sure this will hold up cross-platform. More testing required.
            var selectedImg = $($this).val().replace(/C:\\fakepath\\/i, '');

            // Get the thumbnail container associated with this input. jQuery tree traversal ftw.
            var $thumbnails = $('.file-attachment-thumbnails', $($this).parent().parent().parent().parent());

            if (typeof (FileReader) !== 'undefined') {
                $thumbnails.show();

                var files = $this[0].files;

                $(files).each(function (idx) {
                    // Limit the maximum number of files a user can upload in one
                    // sitting. This is mostly a sanity check.
                    if (idx >= max_allowed_files) {
                        return false;
                    }

                    var currentFile = this;

                    if (typeof EXIF == "undefined") {
                        throw "EXIF library needs to be included: https://github.com/exif-js/exif-js/blob/master/exif.js";
                    }

                    var exifReader = new FileReader();
                    var dataReader = new FileReader();

                    exifReader.onload = function(e) {
                        console.log(files, 'ex');
                        dataReader.readAsDataURL(files[idx]);
                    }

                    dataReader.onload = function (e) {
                    console.log(files, 'ex')
                        // Generate a quasi-unique id number based on a random number.
                        var id = uid();

                        // Because the change event on file inputs fires when the selected list of files
                        // is replaced, we need to encode the file contents inside hidden fields
                        // between events - otherwise we end up only uploading the files selected
                        // on the most recent click of the input.
                        // 
                        // This will probably break ASP's usual mechanisms for handling uploaded files, and the
                        // files will need to be decoded on the server side before being stored.
                        // 
                        // ALSO: Crappy browsers in memory-constrained environments (ie. iOS) may
                        // struggle with numerous large uploads. More testing recommended.
                        if (currentFile.size < max_upload_size) {
                            var encodedFilename = currentFile.name.replace(/[&<>'"]/g, function (a) {
                                var replacements = {
                                    '&': '&amp;',
                                    '\'': '&apos;',
                                    '"': '&quot;',
                                    '<': '&lt;',
                                    '>': '&gt;'
                                };
                                return replacements[a] || a;

                            }).replace(/</g, '&lt;').replace(/>/g, '&gt;').replace(/"/g, '&quot;');

                            if (currentFile.type.match(/(application\/.*(word|excel|rtf|pdf).*)|text\/.*(plain|excel).*/i)) {
                                $thumbnails.append('<div class="preview doc" title = "' + encodedFilename + '" data-filesize= "' + (currentFile.size / 1048576).toFixed(2) + 'MB" data-id="' + id + '"><a class="close-file"><i class="fa fa-times"></i></a><input type="hidden" name="' + $($this).attr('name') + '" value="' + encodedFilename + "|" + e.target.result + '"></div>');
                                if ($("#send-message-form .file-attachment .preview").length > 0) $('#file-attachment').show();
                            }
                            else if (currentFile.type.match(/image\/(png|jpe?g|gif)/i)) {
                                // Load the image in preparation for processing.
                                var img = new Image();
                                img.src = e.target.result;

                                // Insert a temporary list item while we wait for the image to load and be resized.
                                var placeholder = $('<div title = "Processing ' + encodedFilename + '" data-filesize= "" data-id=""><div class="preview" style="background-color: #ccc;"></div></div>').appendTo($thumbnails);

                                // Because even this type of image is loaded asynchronously, we need to
                                // wait for the onload event for the image to fire before we can resize it.
                                img.onload = function () {

                                    //loadImage.parseMetaData(
                                    //    img,
                                    //    function (data) {
                                    //        if (!data.imageHead) {
                                    //            return;
                                    //        }
                                    //        // Combine data.imageHead with the image body of a resized file
                                    //        // to create scaled images with the original image meta data, e.g.:
                                    //        var blob = new Blob([
                                    //            data.imageHead,
                                    //            // Resized images always have a head size of 20 bytes,
                                    //            // including the JPEG marker and a minimal JFIF header:
                                    //            loadImage.blobSlice.call(resizedImage, 20)
                                    //        ], { type: resizedImage.type });
                                    //    },
                                    //    {
                                    //        maxMetaDataSize: 262144,
                                    //        disableImageHead: false
                                    //    }
                                    //);

                                    var dataurl = resizeImage(img, EXIF.readFromBinaryFile(exifReader.result).Orientation, max_image_side, currentFile.type);

                                    var replacement = $('<div class="preview" title = "' + encodedFilename + '" data-filesize= "' + (dataurl.length / 1048576).toFixed(2) + 'MB" data-id="' + id + '" style="background-image: url(' + dataurl + ');"><a class="close-file"><i class="fa fa-times"></i></a><input type="hidden" name="' + $($this).attr('name') + '" value="' + encodedFilename + "|" + dataurl + '"></div>');
                                    replacement.appendTo($thumbnails);
                                    placeholder.remove();
                                    $(replacement).find('.close-file').click(function () {
                                        id = $(this)[0].getAttribute('data-id');                                        
                                        $(replacement).remove();
                                        if ($("#send-message-form .file-attachment .preview").length == 0) $('#file-attachment').hide();
                                    });

                                    if ($("#send-message-form .file-attachment .preview").length > 0) $('#file-attachment').show();

                                    // Release the image from memory (maybe)
                                    //img = null;
                                };
                            }
                            else {
                                $thumbnails.append('<div class="preview doc" title = "' + encodedFilename + '" data-filesize= "' + (currentFile.size / 1048576).toFixed(2) + 'MB" data-id="' + id + '"><a class="close-file"><i class="fa fa-times"></i></a><input type="hidden" name="' + $($this).attr('name') + '" value="' + encodedFilename + "|" + e.target.result + '"></div>');
                                if ($("#send-message-form .file-attachment .preview").length > 0) $('#file-attachment').show();
                            }
                        }

                        $($thumbnails).find('.close-file').click(function () {
                            id = $(this).parent()[0].getAttribute('data-id');
                            $($(this).parent()[0]).remove();
                            if ($("#send-message-form .file-attachment .preview").length == 0) $('#file-attachment').hide();
                        });
                    }

                    exifReader.readAsArrayBuffer(files[idx]);

                });
            }

            // The only way to remove files from the upload queue in the input[type="file"] 
            // element is to clone it - since the files attribute is read only the clone
            // will be empty.
            var newClone = $(this).replaceWith($(this).clone(true).val(''));

            // Not sure if all browsers will play nicely with this. Ideally, we want to prevent
            // a duplicate upload, since the file content has already been inserted into the
            // hidden input fields for each thumbnail.
            if (newClone[0].files.length > 0) {
                //throw ('Assertion Failed: File input still contains files.');
            }                                   
        });
    };

    $(document).ready(initUploaders);

}).call(this);