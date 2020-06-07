/**
 * This class is the controller for the main view for the application. It is specified as
 * the "controller" of the Main view class.
 */
Ext.define('Packt.view.main.MainController', {
    extend: 'Ext.app.ViewController',

    alias: 'controller.main',

    onLogout: function (button, e, options) {
        var me = this; 
        Ext.Ajax.request({
            url: 'php/security/logout.php', 
            scope: me, 
            success: 'onLogoutSuccess', 
            failure: 'onLogoutFailure' 
        });
    },

    //onItemSelected: function (sender, record) {
    //    Ext.Msg.confirm('Confirm', 'Are you sure?', 'onConfirm', this);
    //},

    //onConfirm: function (choice) {
    //    if (choice === 'yes') {
    //        //
    //    }
    //}
});
