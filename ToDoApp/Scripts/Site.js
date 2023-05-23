function LoadContent() {
    $.get("/Home/GetPageContent", function (data) {
        $('#ContentID').html(data);
    })
        .fail(function () {
            console.log("Error");
    })
}

function ClearContent() {
        $('#ContentID').html('');
}