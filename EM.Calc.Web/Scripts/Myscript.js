$("#number").keypress(function (e) {
    if (e.keyCode == 32 && !$(this).val() && $(this).hasClass('first')) {
        return false;
    }
    if (e.keyCode == 32 && $(this).val()) {
        $(this).removeClass('last').addClass('after');
        $(this).clone(true).removeClass('first').addClass('clone').addClass('last').val('').appendTo('#double');
        $(".last").focus();
        return false;
    }
});
$("#number").keydown(function (e) {
    if (e.keyCode == 8 && !$(this).val() && $(this).hasClass('clone')) {
        $(this).remove();
        $(".after").focus();
        $(this).removeClass('after').addClass('last');
        return false
    }
});