/*======================================= Barra de Navegação - Scroll =======================================*/
/*================== Scroll ==================*/
window.onscroll = function () {
    navegar();
    scroll();
};

function scroll() {
    if (document.body.scrollTop > 100 || document.documentElement.scrollTop > 100) {
        document.getElementById("navbar").style.top = "0";
    } else {
        document.getElementById("navbar").style.top = "-100%";
    }
}

/*================== Navegação ==================*/
function navegar(){
$('.scrollDirect').bind('click', function(event) {
            var $anchor = $(this);
            $('html, body').stop().animate({
                scrollTop: $($anchor.attr('href')).offset().top
            }, 1000, 'swing');
        });
}

