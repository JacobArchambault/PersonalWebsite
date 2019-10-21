// Cycle through background images with a fade, switching images every six seconds.
$('.pics img:gt(0)').hide();
setInterval(function () {
    $('.pics :first-child').fadeOut()
        .next('img').fadeIn()
        .end().appendTo('.pics');
},
    6000);

// Toggle profile photo with fade on click.
$('.profile img:gt(0)').hide();
$('.profile').click(function () {
    $('.profile :first-child').fadeOut()
        .next('img').fadeIn()
        .end().appendTo('.profile');
});