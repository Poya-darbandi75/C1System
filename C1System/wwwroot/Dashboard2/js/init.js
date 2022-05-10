
"use strict";
/*****Ready function start*****/
$(document).ready(function () {
    $('.input-images').imageUploader({
        //preloaded: preloaded,
        label: 'انتخاب پیوست ها',
        imagesInputName: 'files',
        preloadedInputName: 'files',
        Default: 2 * 1024 * 1024 * 1024
    });

    $('a.active').removeClass('active');
    console.log(location.pathname);
    $('a[href="' + location.pathname.replace("/Details", "") + '"]').addClass('active');
    $('a[href="' + location.pathname.replace("/Details","") + '"]').parent().addClass('is-shown');
    $('a[href="' + location.pathname.replace("/Details", "") + '"]').parent().parent().parent().addClass('open');
    $('.preloader-it > .la-anim-1').addClass('la-animate');
    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var name = $(input).attr('id');
                if (!$("img[data-preview='" + name + "']").hasClass("no-preview")) {
                    $("img[data-preview='" + name + "']").attr('src', e.target.result);
                }
                else {
                    $("img[data-preview='" + name + "']").attr('src', "/images/video-selected.png");
                }
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
    console.log("input");
    $("img.form-image").click(function () {
        var name = $(this).attr('data-preview');
        $('input#' + name).click();
    });
    $(".dropdown.dropdown-language,.dropdown.dropdown-user,.dropdown.dropdown-notification")
        .click(function () {
            if (!$(this).hasClass("show")) {
                $(".dropdown").removeClass("show");
            }
            $(this).toggleClass("show");
        });

    $("input.form-control-file").change(function () {
        readURL(this);
    });


});
/*****Ready function end*****/


function preview_images() {
    var total_file = document.getElementById("images").files.length;
    for (var i = 0; i < total_file; i++) {
        $('#image_preview').append("<div class='col-md-4'><img class='img-responsive' src='" + URL.createObjectURL(event.target.files[i]) + "'></div>");
    }
}
