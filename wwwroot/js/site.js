﻿//#region 1 Function declarations

// Cycle through items with fade effect.
function fadeCarousel(containerClass) {
    $(containerClass + '> :first-child').fadeOut()
        .next().fadeIn()
        .end().appendTo(containerClass);
}

// For each click on my resume or CV, send a record of it to Google Analytics.
function handleDocumentLinkClicks(url) {
    gtag('event', 'click', {
        'send_to': 'UA-150909892-1',
        'event_category': 'Documents',
        'event_label': url
    });
}
//#endregion

// #region 2 Function calls

// Hide all but the first element in my image container classes on startup.
$('.profile > :gt(0)').hide();
$('.pics > :gt(0)').hide();

// Cycle through background images with a fade, switching images every six seconds.
setInterval(() => { fadeCarousel(".pics"); }, 6000);

// #endregion