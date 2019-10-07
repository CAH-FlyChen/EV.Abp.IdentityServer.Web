(function ($) {
    var xxx = new abp.ModalManager(abp.appPath + 'IdentityServer/AllowedGrantTypes/CreateModal');

    abp.modals.ClientEditModal = function () {

        var initModal = function (publicApi, args) {
            publicApi.getModal()
                .find('#aaa')
                .click(function () {
                    //var $this = $(this);
                    //$("#Tenant_DefaultConnectionString_Wrap").toggleClass("d-none");
                    //$this.val($this.prop("checked"));
                    //alert("cccc");
                    //debugger;
                    xxx.open();
                });
        };

        return {
            initModal: initModal
        };
    };

})(jQuery);