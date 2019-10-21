//#region 1. Function declarations

// Toggle profile photo with fade on click.
function fadeCarousel() {
    $('.profile').click(function () {
        $('.profile :first-child').fadeOut()
            .next('img').fadeIn()
            .end().appendTo('.profile');
    });
}

// Cycle through background images with a fade, switching images every six seconds.
function headerFadeCarousel() {
    setInterval(function () {
        $('.pics :first-child').fadeOut()
            .next('img').fadeIn()
            .end().appendTo('.pics');
    }, 6000);
}

//#endregion

$('.pics img:gt(0)').hide();
$('.profile img:gt(0)').hide();

headerFadeCarousel();
fadeCarousel();