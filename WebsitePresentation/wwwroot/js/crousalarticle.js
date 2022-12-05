//SlideShow VideoPost And ArticlePost For HomePage
var slideIndexy = 0;
carouselarticle();
function carouselarticle() {
    var j;
    var y = document.getElementsByClassName("mySlidesArticle");
    for (j = 0; j < y.length; j++) {
        y[j].style.display = "none";
    }
    slideIndexy++;
    if (slideIndexy > y.length) { slideIndexy = 1 }
    y[slideIndexy - 1].style.display = "block";
    setTimeout(carouselarticle, 3000); // Change image every 3 seconds
}
