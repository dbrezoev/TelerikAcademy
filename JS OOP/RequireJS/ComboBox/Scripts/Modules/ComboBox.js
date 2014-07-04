define(['jquery'], function () {
    
    $.fn.ComboBox = function(){
        var $this = this;

        var $that = $this;
        $that.find('.person-item').addClass('hidden').hide();
        $that.find('.person-item').first().show();

        var visible = false;
        $that.on('click','img', function () {
            var $this = $(this);
            console.log(this);
            
            if (visible) {
                $that.find('.person-item').hide();
                $this.parents('.person-item').show();
                visible = false;
            }                
            else {
                $('.hidden').show();
                visible = true;
            }
        })
    }
})