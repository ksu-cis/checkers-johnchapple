﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var checkers = document.getElementsByTagName("circle")

var selectedChecker

function onClick(event) {
    if (selectedChecker) {
        event.target.setAttribute("stroke", "gold");
    }
    selectedChecker = event.target;
    event.target.setAttribute("stroke", "green");
}

function onClickSquare(event) {
}

for (var i = 0; i < checkers.length; i++) {
    checkers[i].addEventListener('click', onClick)
}

var squares = document.getElementsByTagName("square")
for (var j = 0; j < squares.length; j++) {
    squares[j].addEventListener('click', onClickSquare);
}