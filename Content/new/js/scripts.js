$(document).ready(function () {
    /*dropdown multi-select checkbox/switch*/
    var options = [];

    // $('.dropdown-menu a').on('click', function (event) {

    //     var $target = $(event.currentTarget),
    //         val = $target.attr('data-value'),
    //         $inp = $target.find('input'),
    //         idx;

    //     if ((idx = options.indexOf(val)) > -1) {
    //         options.splice(idx, 1);
    //         setTimeout(function () { $inp.prop('checked', true) }, 0);
    //     } else {
    //         options.push(val);
    //         setTimeout(function () { $inp.prop('checked', false) }, 0);
    //     }

    //     $(event.target).blur();

    //     console.log(options);
    //     return false;
    // });

    // $('.dropdown-menu').find("a").each(function () {
    //     $(this).click(function (event) {

    //         var $target = $(event.currentTarget),
    //             val = $target.attr('data-value'),
    //             $inp = $target.find('input'),
    //             idx;

    //         if ((idx = options.indexOf(val)) > -1) {
    //             options.splice(idx, 1);
    //             setTimeout(function () { $inp.prop('checked', true) }, 0);
    //         } else {
    //             options.push(val);
    //             setTimeout(function () { $inp.prop('checked', false) }, 0);
    //         }

    //         $(event.target).blur();

    //         console.log(options);
    //         return false;
    //     });
    // });


    // $(function () {
    //     $('.filter-search').keyup(function () {
    //         var current_query = $('.filter-search').val();
    //         if (current_query !== "") {
    //             $("li .list-group-item").hide();
    //             $("li .list-group-item").each(function () {
    //                 var current_keyword = $(this).text();
    //                 if (current_keyword.toLowerCase().indexOf(current_query) >= 0) {
    //                     $(this).show();
    //                 };
    //             });
    //         } else {
    //             $("li .list-group-item").show();
    //         };
    //     });
    // });

    /*mobile nav*/
    $('#toggle').click(function () {
        $(this).toggleClass('active');
        $('#overlay').toggleClass('open');
    });

});