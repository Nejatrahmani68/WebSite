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
window.onscroll = function () { myFunction() };

// Get the navbar
var navbar = document.getElementById("categorynav");

// Get the offset position of the navbar
var sticky = navbar.offsetTop;

// Add the sticky class to the navbar when you reach its scroll position. Remove "sticky" when you leave the scroll position
function myFunction() {
    if (window.pageYOffset >= sticky) {
        navbar.classList.add("sticky")
    } else {
        navbar.classList.remove("sticky");
    }
}