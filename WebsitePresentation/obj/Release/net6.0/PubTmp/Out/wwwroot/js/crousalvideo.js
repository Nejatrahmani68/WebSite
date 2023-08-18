//SlideShow VideoPost And ArticlePost For HomePage
var slideIndexv = 0;
carouselvideo();
function carouselvideo() {
    var ii;
    var xx = document.getElementsByClassName("mySlidesVideo");
    for (ii = 0; ii < xx.length; ii++) {
        xx[ii].style.display = "none";
    }
    slideIndexv++;
    if (slideIndexv > xx.length) { slideIndexv = 1 }
    xx[slideIndexv - 1].style.display = "block";
    setTimeout(carouselvideo, 3000); // Change image every 3 seconds
}