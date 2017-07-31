'use strict';
/* global jQuery, PhotoSwipe, PhotoSwipeUI_Default, console */
(function ($) {
    // Init empty gallery array
    var container = [];
    // Loop over gallery items and push it to the array
    $('a.gallery-item').each(function (i) {
        var $link = $(this);
        var item = {
            src: $link.attr('href'),
            w: 0,
            h: 0,
            title: $link.data('caption'),
            pid: i
        };
        container.push(item);
        // Define click event on gallery item
        $link.click(function (event) {
            // Prevent location change
            event.preventDefault();
            // Define object and gallery options
            console.log(this);
            var $pswp = $('.pswp')[0],
                options = {
                    index: item.pid,
                    bgOpacity: 0.85,
                    showHideOpacity: true,
                    history: true,
                    galleryPIDs: true,
                    getThumbBoundsFn: false,
                    shareButtons: [
                        { id: 'download', label: 'Download image', url: '{{raw_image_url}}', download: true }
                    ]
                };
            // Initialize PhotoSwipe            
            var gallery = new PhotoSwipe($pswp, PhotoSwipeUI_Default, container, options);
            gallery.listen('gettingData', function (index, item) {
                if (item.w < 1 || item.h < 1) { // unknown size
                    var img = new Image();
                    img.onload = function () { // will get size after load
                        item.w = this.width; // set image width
                        item.h = this.height; // set image height
                        gallery.invalidateCurrItems(); // reinit Items
                        gallery.updateSize(true); // reinit Items
                    }
                    img.src = item.src; // let's download image
                }
            });

            gallery.listen('close', function () {
                setTimeout(function () {
                    $('.loading').css('display', 'none');
                }, 500);
            });

            gallery.init();
        });
    });
}(jQuery));