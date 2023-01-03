var slideIndexpv = 0;
carouselpostview();
function carouselpostview() {
    var p;
    var pv = document.getElementsByClassName("mySlidesPostView");
    for (p = 0; p < pv.length; p++) {
        pv[p].style.display = "none";
    }
    slideIndexpv++;
    if (slideIndexpv > pv.length) { slideIndexpv = 1 }
    pv[slideIndexpv - 1].style.display = "block";
    setTimeout(carouselpostview, 3000); // Change image every 2 seconds
}