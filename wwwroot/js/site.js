// For each click on my resume or CV, send a record of it to Google Analytics.
function handleDocumentLinkClicks(url) {
    gtag('event', 'click', {
        'send_to': 'UA-150909892-1',
        'event_category': 'Documents',
        'event_label': url
    });
}