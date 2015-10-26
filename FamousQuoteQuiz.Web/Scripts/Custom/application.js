$(document).ready(function () {
    $(".authors").click(function () {
        var questionId = $(".question").attr('id');
        var authorId = $(this).attr('id');
        $.ajax({
            url: "/Main/IsUserChoiseCorrect",
            method: "POST",
            data: { questionId: questionId, authorId: authorId },
            success: function (data) {
                $("#result_view").html(data);
                $("#authors_container").hide();
                $("#result_view").show();
                $(".hidden_el").show();
            }
        });
    });

    $(".btn_binMode").click(function () {
        var questionId = $(".question").attr('id');
        var authorId = $(".authorId").attr('id').split('-')[1];
        var typeOfAnswer = $(this).attr('id').split('-')[1];
        $.ajax({
            url: "/Main/IsUserChoiseCorrect",
            method: "POST",
            data: { questionId: questionId, authorId: authorId, isAnswerCorrect: typeOfAnswer },
            success: function (data) {
                $("#result_view").html(data);
                $("#authors_container").hide();
                $("#result_view").show();
                $(".hidden_el").show();
            }
        });
    });

    $('.rb_mode').change(function () {
        var isBinaryMode = false;
        if ($(this).attr('id') == 'binary_mode') {
            isBinaryMode = true;
        }
        console.log(isBinaryMode);
        $.ajax({
            url: "/Main/ChangeMode",
            method: "POST",
            data: { isBinaryMode: isBinaryMode }
        });
    });
});

