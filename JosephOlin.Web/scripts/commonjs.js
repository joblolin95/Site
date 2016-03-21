$(function () {
    $('.smooth-scroll').bind('click', function (event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top - 100
        }, 1500, 'easeInOutExpo');
        event.preventDefault();
    });
});

// Closes the responsive menu on menu item click
$('.navbar-collapse ul li a').click(function () {
    $('.navbar-toggle:visible').click();
});

//This is currently toggling the responsive menu
// when the navbar-brand is clicked
$('.navbar-brand').click(function () {
    if ($('.navbar-toggle').is(':visible') === true) {
        $('.navbar-toggle:visible').click();
    }
});