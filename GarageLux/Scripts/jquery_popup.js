/// <reference path="jquery-1.9.1.js" />


// Get the modal
var modal = document.getElementById("myModal");


// Get the button that opens the modal
//var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
//var span = document.getElementsByClassName("close")[0];

// When the user clicks the button, open the modal
//btn.onclick = function () {
//    modal.style.display = "block";
//}

// When the user clicks on <span> (x), close the modal
//span.onclick = function () {
//    modal.style.display = "none";
//}

$("#btnClose").click(function () { $("#myModal").css("display", "none"); });

//$(document).click(
//    function (event) {
//        if (event.target != $("#myModal").event.target)
//        $("#myModal").css("display", "none");
//    });




// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

//$("#myBtn").click(function () { modal.style.display = "block"; });
$("#myBtn").click(function () { $("#myModal").css("display", "block"); });
