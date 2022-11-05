// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/* Open when someone clicks on the span element */
function openNav() {
    document.getElementById("myNav").style.width = "100%";
}

/* Close when someone clicks on the "x" symbol inside the overlay */
function closeNav() {
    document.getElementById("myNav").style.width = "0%";
}
//SlideShow VideoPost And ArticlePost For HomePage
var slideIndex = 0;
var slideIndexy = 0;
carousel();

function carousel() {
    var i;
    var j;
    var x = document.getElementsByClassName("mySlides");
    var y = document.getElementsByClassName("mySlidesArticle");
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    for (j = 0; j < y.length; j++) {
        y[j].style.display = "none";
    }
    slideIndex++;
    slideIndexy++;
    if (slideIndex > x.length) { slideIndex = 1 }
    if (slideIndexy > y.length) { slideIndexy = 1 }
    x[slideIndex - 1].style.display = "block";
    y[slideIndexy - 1].style.display = "block";
    setTimeout(carousel, 2000); // Change image every 2 seconds
}