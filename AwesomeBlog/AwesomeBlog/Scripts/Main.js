$(document).ready(function () {
    //select likes <span>
    $('.like').on('click', function () {
        var id = $(this).data('id');
        var postLikes = $(this);
        $.get('/home/like/' + id, function (data) {
            $(postLikes).html(data);
        });
    });

    $('.showComments').on('click', function () {
        $(this).parent().find('.commentsDiv').slideToggle();


    });
    $('.commentForm').on('submit', function (event) {
        //stop the form from submitting
        event.preventDefault();
        var theForm = $(this);
        var id = $(this).data('id');
        //$(this).serialize sends the data
        $.post('/home/AddComment/' + id, $(this).serialize(), function (data) {
            //adding the new comment before the form
            theForm.before(data);
            //clear out values on the form
            theForm.find('.commentContent', '.commentContents').val('');
        });

    });
});












