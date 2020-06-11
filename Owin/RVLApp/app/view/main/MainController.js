/**
 * This class is the controller for the main view for the application. It is specified as
 * the "controller" of the Main view class.
 */
Ext.define('App.view.main.MainController', {
    extend: 'Ext.app.ViewController',

    alias: 'controller.main',
    requires: [
        'App.util.Util'
    ],
    onLogout: function (button, e, options) {
        var me = this; 
        Ext.Ajax.request({
            url: 'http://localhost:57410/api/logout', 
            scope: me, 
            success: 'onLogoutSuccess', 
            failure: 'onLogoutFailure' 
        });
    },

    onLogoutFailure: function (conn, response, options, eOpts) {
        App.util.Util.showErrorMsg(conn.responseText);
    },

    onLogoutSuccess: function (conn, response, options, eOpts) {
        
        var result = App.util.Util.decodeJSON(conn.responseText);
        if (result.success) { 
            this.getView().destroy(); 
            window.location.reload(); 
        } else {
            App.util.Util.showErrorMsg(result.msg); 
        }
    }


});
