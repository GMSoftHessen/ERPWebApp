Ext.define('Packt.view.login.LoginController', {
    extend: 'Ext.app.ViewController',
    alias: 'controller.login',

    requires: [
        'Packt.view.login.CapsLockTooltip',
        'Packt.util.Util'
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
            Packt.util.Util.decodeJSON(action.response.responseText);
        switch (action.failureType) {
            case Ext.form.action.Action.CLIENT_INVALID:
                Packt.util.Util.showErrorMsg('Form fields may not be submitted with invalid values');
                break;
            case Ext.form.action.Action.CONNECT_FAILURE:
                Packt.util.Util.showErrorMsg(action.response.responseText);
                break;
            case Ext.form.action.Action.SERVER_INVALID:
                Packt.util.Util.showErrorMsg(result.msg);
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
        Ext.create('Packt.view.main.Main');
    }
});