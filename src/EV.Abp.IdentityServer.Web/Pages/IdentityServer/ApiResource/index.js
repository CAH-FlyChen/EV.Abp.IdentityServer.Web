﻿$(function () {
    var l = abp.localization.getResource('EV');
    var dataTable = $('#DataTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(eV.abp.identityServer.apiResource.getList),
        columnDefs: [
            { data: "name" },
            { data: "displayName" },
            { data:"enabled"},
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

    var createModal = new abp.ModalManager(abp.appPath + 'IdentityServer/ApiResource/CreateModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

    var editModal = new abp.ModalManager(abp.appPath + 'IdentityServer/ApiResource/EditModal');


    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

});