$(function(){
    $('.contatos').submit(function(){
        $(".loading").css("display", "inline-block");
        $.ajax({
            url: 'support/send-form.php',
            type: 'POST',
            data: $('.contatos').serialize(),
            success: function(data){
                $('.mostrar').html(data);
                $('.loading').hide();
                $(".loading").css("display", "none");
				$('.contatos')[0].reset();
            }
        });
        return false;
    });
});