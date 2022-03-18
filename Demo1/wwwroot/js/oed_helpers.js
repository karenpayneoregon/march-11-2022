var oed_helpers = oed_helpers || {};
oed_helpers = function () {
    "use strict";

    /*
     * Example for having a method available throughout the app
     */
    var dummyConfirm = (e) => {

        BootstrapDialog.confirm({
            title: 'WARNING',
            verticalCentered: true,
            message: 'Commit your changes are not reversible, continue?',
            type: BootstrapDialog.TYPE_WARNING,
            closable: true,
            draggable: true,
            btnCancelLabel: 'Do not',
            btnOKLabel: 'Just do it',
            btnOKClass: 'btn-warning',
            callback: function(result) {
                if (result) {
                    alert("Run commit.");
                } else {
                    alert("Nope, chicken");
                }
            }
        });
    };


    return {
        ChickenConfirm: dummyConfirm
    };

}();