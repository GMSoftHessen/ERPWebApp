Ext.define('Packt.view.login.Login', {
    extend: 'Ext.window.Window',
    xtype: 'login-dialog',

    requires: [
        'Packt.view.login.LoginController'
    ],

    controller: 'login',

    autoShow: true,
   // height: 230,
    width: 360,
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
                    fieldLabel: 'User',
                    allowBlank: false,
                   // vtype: 'alphanum',
                    minLength: 3,
                    msgTarget: 'under'
                },
                {
                    inputType: 'password',
                    id: 'password',
                    name: 'Password',
                    fieldLabel: 'Password',
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
            text: 'Cancel',
            iconCls: 'fa fa-times fa-lg',
            listeners: {
                click: 'onButtonClickCancel'
            }
        },
        {
            text: 'Login',
            iconCls: 'fa fa-sign-in fa-lg',
            listeners: {
                click: 'onButtonClickSubmit'
            }
        }
    ],

    defaults: {
        anchor: '100%',
        labelWidth: 120
    }   

});