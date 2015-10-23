$(document).ready(function () {
    $(".authors").click(function () {
        var questionId = $(".question").attr('id');
        var authorId = $(this).attr('id');
        $.ajax({
            url: "/Home/IsUserChoiseCorrect",
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

    $('.rb_mode').change(function () {
        var isBinaryMode = false;
        if ($(this).attr('id') == 'binary_mode') {
            isBinaryMode = true;
        }
        console.log(isBinaryMode);
        $.ajax({
            url: "/Home/ChangeMode",
            method: "POST",
            data: { isBinaryMode: isBinaryMode }
        });
    })
})