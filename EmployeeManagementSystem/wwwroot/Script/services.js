$(document).ready(function () {
    $(".loader").show();
    $.ajax({
        "type": "Get",
        "url": "/home/GetEmployee",
        success: (function (resp) {
            $(".loader").hide();
            $("#list").html(resp);

        }),
        error: (function (ex) {
            $(".loader").hide();
            alert("An error has occured");
        })
    });
})


function searchFunction() {
    var value = $("#searchString").val().toLowerCase();
    $("#myTable tr").filter(function () {
        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
    });
 }
function addFunction() {
    $("#list").empty(); $(".loader").show();
    $.ajax({
        "type": "Get",
        "url": "/home/Addemployee",
        success: (function (resp) {
            $(".loader").hide();
            $("#list").html(resp);

        }),
        error: (function (ex) {
            $(".loader").hide();
            alert("An error has occured");
        })
    });
}

function submitFunction() {
    var firstName = $("#firstName").val();
    var lastName = $("#lastName").val();
    var dateOfBirth = $("#dateOfBirth").val();
    var department = $("#department").val();
    $("#list").empty();
    $(".loader").show();
    $.ajax({
        "type": "Post",
        "url": "/home/Addemployee",
        "data": {
            'firstName': firstName,
            'lastName': lastName,
            'dateOfBirth': dateOfBirth,
            'department': department
        },
        success: (function (resp) {
            $(".loader").hide();
            $("#list").html(resp);

        }),
        error: (function (ex) {
            $(".loader").hide();
            alert("An error has occured");
        })
    });
 }