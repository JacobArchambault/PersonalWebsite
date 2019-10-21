$('.pics img:gt(0)').hide();
setInterval(function () {
    $('.pics :first-child').fadeOut()
        .next('img').fadeIn()
        .end().appendTo('.pics');
},
    4000);