//#region 1. Function declarations

// Toggle profile photo with fade on click.
function fadeCarousel(containerClass) {
    $(containerClass + '> :gt(0)').hide();
    $(containerClass).click(function () {
        $(containerClass + '> :first-child').fadeOut()
            .next().fadeIn()
            .end().appendTo(containerClass);
    });
}

// Cycle through background images with a fade, switching images every six seconds.
function headerFadeCarousel(containerClass) {
    $(containerClass + '> :gt(0)').hide();
    setInterval(function () {
        $(containerClass + '> :first-child').fadeOut()
            .next().fadeIn()
            .end().appendTo(containerClass);
    }, 6000);
}

//#endregion


headerFadeCarousel(".pics");
fadeCarousel(".profile");

