Ext.define('Packt.view.login.LoginController', {
    extend: 'Ext.app.ViewController',
    alias: 'controller.login',

    requires: [
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




    onLoginSuccess: function (form, action) {
        this.getView().close();
        Ext.create('Packt.view.main.Main');
    }
});