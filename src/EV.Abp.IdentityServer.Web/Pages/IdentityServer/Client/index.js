$(function () {
    // 通过该方法来为每次弹出的模态框设置最新的zIndex值，从而使最新的modal显示在最前面    
    $(document).on('show.bs.modal', '.modal', function () {
        var zIndex = 1040 + (10 * $('.modal:visible').length);
        $(this).css('z-index', zIndex);
        setTimeout(function () {
            $('.modal-backdrop').not('.modal-stack').css('z-index', zIndex - 1).addClass('modal-stack');
        }, 0);
    });
    
    var l = abp.localization.getResource('EV');
    var dataTable = $('#DataTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(eV.abp.identityServer.client.getList),
        columnDefs: [
            { data: "clientName" },
            { data: "enabled"},
            {
                class: "text-right",
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            }
                        ]
                }
            }
        ]
    }));

    var createModal = new abp.ModalManager(abp.appPath + 'IdentityServer/Client/CreateModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

    var editModal =
        new abp.ModalManager({
            viewUrl: abp.appPath + 'IdentityServer/Client/EditModal',
            modalClass: 'ClientEditModal'
        });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

});