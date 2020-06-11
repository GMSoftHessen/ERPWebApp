

Ext.define('App.view.login.Login', {
    extend: 'Ext.window.Window',
    xtype: 'login-dialog',

    requires: [
        'App.view.login.LoginController',
        'App.view.locale.Translation',
        'App.view.login.RegisterForm'
    ],

    controller: 'login',
    autoShow: true,
    width: 500,
    reference: 'login',
   // height: 230,
    

    layout: {
        type: 'card'
    },
    closeAction: 'hide',
    closable: false,
    draggable: false,
    resizable: false,

    items: [
        {
            xtype: 'form',
            iconCls: 'fa fa-key fa-lg',
            title: 'Login',
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
                },
                {
                    text: translations.register,                    
                    listeners: {
                        click: 'onButtonClickRegister'
                    }
                }
            ]
        },
        {

            xtype: 'form-register'
          
        }
    ],   

    defaults: {
        anchor: '100%',
        labelWidth: 120
    }   

});