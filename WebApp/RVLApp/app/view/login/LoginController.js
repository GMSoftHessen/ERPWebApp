Ext.define('App.view.login.LoginController', {
    extend: 'Ext.app.ViewController',
    alias: 'controller.login',

    requires: [
        'App.view.login.CapsLockTooltip',
        'App.util.Util',
        'App.util.SessionMonitor'
    ],

    onTextFieldSpecialKey: function (field, e, options) {
    },
    onTextFieldKeyPress: function (field, e, options) {
    },
    onButtonClickCancel: function (button, e, options) {
        this.lookupReference('form').reset();
    },
    onButtonClickSubmit: function (button, e, options) {
        var me = this;
        if (me.lookupReference('form').isValid()) {
            me.doLogin();
        }
    },
    doLogin: function () {
        this.getView().mask('Authenticating... Please wait...');
        var me = this,
            form = me.lookupReference('form');

        form.submit({
            clientValidation: true,
            url: 'http://localhost:57410/api/Login',
            scope: me,
            success: 'onLoginSuccess',
            failure: 'onLoginFailure'
        });
    },
    onLoginFailure: function (form, action) {
        this.getView().unmask();
        var result =
            App.util.Util.decodeJSON(action.response.responseText);
        switch (action.failureType) {
            case Ext.form.action.Action.CLIENT_INVALID:
                App.util.Util.showErrorMsg('Form fields may not be submitted with invalid values');
                break;
            case Ext.form.action.Action.CONNECT_FAILURE:
                App.util.Util.showErrorMsg(action.response.responseText);
                break;
            case Ext.form.action.Action.SERVER_INVALID:
                App.util.Util.showErrorMsg(result.msg);
        }
    },
    onTextFieldSpecialKey: function (field, e, options) {

        if (e.getKey() === e.ENTER) {
            this.doLogin();
        }

        var charCode = e.getCharCode(),
            me = this;
        if ((e.shiftKey && charCode >= 97 && charCode <= 122) || //#2
            (!e.shiftKey && charCode >= 65 && charCode <= 90)) {
            if (me.capslockTooltip === undefined) { //#3
                me.capslockTooltip = Ext.widget('capslocktooltip'); //#4
            }
            me.capslockTooltip.show(); //#5
        } else {
            if (me.capslockTooltip !== undefined) { //#6
                me.capslockTooltip.hide(); //#7
            }
        }
    },
    

    onLoginSuccess: function (form, action) {
        this.getView().unmask();
        this.getView().close();
        Ext.create('App.view.main.Main');
        App.util.SessionMonitor.start();
    }
});