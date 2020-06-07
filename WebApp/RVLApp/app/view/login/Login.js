

Ext.define('App.view.login.Login', {
    extend: 'Ext.window.Window',
    xtype: 'login-dialog',

    requires: [
        'App.view.login.LoginController',
        'App.view.locale.Translation'
    ],

    controller: 'login',

    autoShow: true,
    width: 400,

   // height: 230,
    

    //layout: {
    //    type: 'fit'
    //},


    iconCls: 'fa fa-key fa-lg',
    title: 'Login',
    closeAction: 'hide',
    closable: false,
    draggable: false,
    resizable: false,

    items: [
        {
            xtype: 'form',
            reference: 'form',
            bodyPadding: 15,
            defaults: {
                xtype: 'textfield',
                anchor: '100%',
                labelWidth: 80
            },
            items: [
                {
                    name: 'UserName',
                    fieldLabel: translations.user,
                    allowBlank: false,
                   // vtype: 'alphanum',
                    minLength: 3,
                    msgTarget: 'under'
                },
                {
                    inputType: 'password',
                    id: 'password',
                    name: 'Password',
                    fieldLabel: translations.password,
                    enableKeyEvents: true,
                    maxLength: 15,
                    minLength: 8,
                    allowBlank: false,
                    msgTarget: 'under',
                    listeners: {
                        specialKey: 'onTextFieldSpecialKey'
                    }
                }, {
                    xtype: 'checkbox',
                    fieldLabel: 'Remember me',
                    name: 'remember'
                }
            ]
        }
    ],

    buttons: [
        {
            text: translations.cancel,
            iconCls: 'fa fa-times fa-lg',
            listeners: {
                click: 'onButtonClickCancel'
            }
        },
        {
            text: translations.login,
            iconCls: 'fa fa-sign-in fa-lg',
            listeners: {
                click: 'onButtonClickSubmit'
            }
        }, {

            xtype: 'translation',
            align: 'left'
        }
    ],

    defaults: {
        anchor: '100%',
        labelWidth: 120
    }   

});