$(document).ready(function () {

    $("#clicker").click(function () {

        oedDialogs.showMessage();
    });


});

function openNav() {
    document.getElementById("SideNavigation").style.width = "450px";
    document.getElementById("main").style.marginLeft = "450px";
}

function closeNav() {
    document.getElementById("SideNavigation").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
}