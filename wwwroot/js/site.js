//#region 1 Function declarations
// Toggles items with fade effect.
function fadeCarousel(containerClass) {
    $(containerClass + '> :first-child').fadeOut()
        // cyles through elements successively
        .next().fadeIn()
        // starts the process over at the end.
        .end().appendTo(containerClass);
}

//#endregion

// #region 2 Employed functions.

// Hide all but the first element in my image container classes.
$('.profile > :gt(0)').hide();
$('.pics > :gt(0)').hide();

// Cycle through background images with a fade, switching images every six seconds.
setInterval(() => {
    fadeCarousel(".pics");
}, 6000);

// #endregion