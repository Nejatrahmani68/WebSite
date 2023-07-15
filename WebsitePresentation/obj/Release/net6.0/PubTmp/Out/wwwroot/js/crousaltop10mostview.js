//SlideShow VideoPost And ArticlePost For HomePage
var slideIndextt = 0;
mySlidesTop10MostView();
function mySlidesTop10MostView() {
    var l;
    var o = document.getElementsByClassName("mySlidesTop10MostView");
    for (l = 0; l < o.length; l++) {
        o[l].style.display = "none";
    }
    slideIndextt++;
    if (slideIndextt > o.length) { slideIndextt = 1 }
    o[slideIndextt - 1].style.display = "block";
    setTimeout(mySlidesTop10MostView, 3000); // Change image every 3 seconds
}