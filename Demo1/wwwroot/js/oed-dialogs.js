var oedDialogs = oedDialogs || {};
oedDialogs = function () {

    var showMessage = (e) => {

        BootstrapDialog.show({
            message: 'Example for <b>dialogs</b> from a class',
            verticalCentered: true,
            onhidden: function () {
                oedDialogs.ChickenConfirm();
            }
        });

    };

    var YesMessageBox = {};
    var NoMessageBox = {};

    var dummyConfirm = (e) => {

        BootstrapDialog.confirm({
            title: 'WARNING',
            verticalCentered: true,
            message: 'Commit your changes are not reversible, continue?',
            type: BootstrapDialog.TYPE_DANGER,
            closable: true,
            draggable: true,
            btnCancelLabel: 'Do not',
            btnOKLabel: 'Just do it',
            btnOKClass: 'btn-warning',
            callback: function(result) {
                if (result) {
                    YesMessageBox();
                } else {
                    NoMessageBox();
                }
            }
        });
    };


    YesMessageBox = (e) => {

        BootstrapDialog.show({
            title: 'Confirm',
            message: 'Here we go',
            verticalCentered: true
        });
    };

    NoMessageBox = (e) => {

        BootstrapDialog.show({
            title: 'Title',
            message: 'chicken',
            verticalCentered: true
        });
    };

    return {
        ChickenConfirm: dummyConfirm,
        showMessage: showMessage
    };

}();