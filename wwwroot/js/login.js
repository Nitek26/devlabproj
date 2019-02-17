$(function () {
    var disableAnimation = localStorage.getItem("disableAnimation");
    if (!disableAnimation) {
        showIntroAnimation();
        localStorage.setItem("disableAnimation", "true");
    }
    else {
        $(".bg-bubbles").remove();
        $("#shadow-wrapper").fadeOut(500);
        $(".wrapper").fadeIn(500);
        $("#loginForm-wrapper").removeClass("inner-shadow");
        $("#loginForm-wrapper").addClass("inner-shadow-light");
    }
});

function showIntroAnimation() {
    $("#loginForm-wrapper").animate(function () { $(this).stop().animate({ boxShadow: "200px 200px -100px -100px #010101" }, 2100); },
        function () { $(this).stop().animate({ boxShadow: "20px -20px 200px 100px #010213" }, 2000); });
    setTimeout(fadeInAndOut, 1000);
}

function fadeInAndOut() {
    $("#shadow-wrapper").fadeOut(2000);
    $(".wrapper").fadeIn(3000);

}