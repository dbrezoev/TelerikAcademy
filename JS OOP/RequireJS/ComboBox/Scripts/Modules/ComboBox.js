define(['jquery'], function ($) {
    
    $.fn.ComboBox = function(){
        var $this = this;

        var $that = $this;
        $that.find('.person-item').addClass('hidden').hide();
        $that.find('.person-item').first().show();

        var visible = false;
        $that.find('.person-item').on('click', function () {
            var $this = $(this);
            
            if (visible) {
                $that.find('.person-item').hide();
                $this.show();
                visible = false;
            }
            else {
                $('.hidden').show();
                visible = true;
            }
        })
    }
})