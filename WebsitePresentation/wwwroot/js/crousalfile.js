//SlideShow VideoPost And ArticlePost For HomePage
var slideIndexz = 0;
carouselfile();
function carouselfile() {
    var k;
    var z = document.getElementsByClassName("mySlidesFile");
    for (k = 0; k < z.length; k++) {
        z[k].style.display = "none";
    }
    slideIndexz++;
    if (slideIndexz > z.length) { slideIndexz = 1 }
    z[slideIndexz - 1].style.display = "block";
    setTimeout(carouselfile, 3000); // Change image every 3 seconds
}