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

    if (document.getElementById('firstName').value == '') { alert('field is required for First Name '); return }
    if (document.getElementById('lastName').value == '') { alert('field is required for Last Name '); return }
    if (document.getElementById('dateOfBirth').value == '') { alert('field is required for Date Of Birth'); return }
    if (document.getElementById('department').value == '') { alert('field is required for Department'); return }
   
       
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