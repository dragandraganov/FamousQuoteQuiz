$(document).ready(function () {
    $(".authors").click(function () {
        var questionId = $(".question").attr('id').split('-')[1];
        var authorId = $(this).attr('id');
        $.ajax({
            url: "/Main.aspx/IsUserChoiseCorrect",
            method: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify({ questionId: questionId, authorId: authorId, isAnswerCorrect: true }),
            success: function (data) {
                renderResult(data);
            }
        });
    });

    $(".btn_guess").click(function () {
        var questionId = $(".question").attr('id').split('-')[1];
        var authorId = $(".authorId").attr('id').split('-')[1];
        var typeOfAnswer = $(this).attr('id').split('_')[1];
        $.ajax({
            url: '/Main.aspx/IsUserChoiseCorrect',
            method: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify({ questionId: questionId, authorId: authorId, isAnswerCorrect: typeOfAnswer }),
            success: function (data) {
                renderResult(data);
            }
        });
    });

    $('.rb_mode').change(function () {
        var isBinaryMode = false;
        if ($(this).find("input").attr('id') == 'binary_mode') {
            isBinaryMode = true;
        }
        $.ajax({
            url: "/Settings.aspx/ChangeMode",
            method: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify({ isBinaryMode: isBinaryMode })
        });
    });
});

function renderResult(data) {
    $("#result_authorName").html(data.d.Item2);
    if (data.d.Item1) {
        $("#result_success").show();
    }
    else {
        $("#result_mistake").show();
    }
    $("#result_view").show();
    $("#authors_container").hide();
    $("#btn_next").show();
}

