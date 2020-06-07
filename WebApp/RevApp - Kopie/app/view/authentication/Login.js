Ext.define('App.view.authentication.Login', {
    extend: 'App.view.authentication.LockingWindow',
    xtype: 'login-dialog',

    requires: [
        'App.view.authentication.Dialog',
        'Ext.container.Container',
        'Ext.form.field.Text',
        'Ext.form.field.Checkbox',
        'Ext.button.Button'
    ],

    title: 'Let\'s Log In',
    defaultFocus: 'authdialog', // Focus the Auth Form to force field focus as well

    items: [
        {
            xtype: 'authdialog',
            defaultButton : 'loginButton',
            autoComplete: true,
            bodyPadding: '20 20',
            //cls: 'auth-dialog-login',
            header: false,
            width: 415,
            layout: {
                type: 'vbox',
                align: 'stretch'
            },

            defaults : {
                margin : '5 0'
            },

            items: [
                {
                    xtype: 'label',
                    text: 'Sign into your account'
                },
                {
                    xtype: 'textfield',
                    cls: 'auth-textbox',
                    name: 'userid',
                    bind: '{userid}',
                    height: 55,
                    hideLabel: true,
                    allowBlank : false,
                    emptyText: 'user id',
                    triggers: {
                        glyphed: {
                            cls: 'trigger-glyph-noop auth-email-trigger'
                        }
                    }
                },
                {
                    xtype: 'textfield',
                    cls: 'auth-textbox',
                    height: 55,
                    hideLabel: true,
                    emptyText: 'Password',
                    inputType: 'password',
                    name: 'password',
                    bind: '{password}',
                    allowBlank : false,
                    triggers: {
                        glyphed: {
                            cls: 'trigger-glyph-noop auth-password-trigger'
                        }
                    }
                },
                {
                    xtype: 'container',
                    layout: 'hbox',
                    items: [
                        {
                            xtype: 'checkboxfield',
                            flex : 1,
                            cls: 'form-panel-font-color rememberMeCheckbox',
                            height: 30,
                            bind: '{persist}',
                            boxLabel: 'Remember me'
                        }
                    ]
                },
                {
                    xtype: 'button',
                    reference: 'loginButton',
                    scale: 'large',
                    ui: 'soft-green',
                    iconAlign: 'right',
                    iconCls: 'x-fa fa-angle-right',
                    text: 'Login',
                    formBind: true,
                    listeners: {
                        click: 'onLoginButton'
                    }
                },{
                    xtype: 'box',
                    html: '<div class="outer-div"><div class="seperator">Select system</div></div>',
                    margin: '10 0'
                },
                {
                    xtype: 'combobox',
                    label: 'Choose State',
                   // queryMode: 'local',
                    displayField: 'name',
                    valueField: 'abbr',
                    //cls:'select-wrapper',
                    // For the dropdown list
                    removeCls:true,
                    itemTpl: '<span role="option" class="x-boundlist-item">{abbr} - {name}</span>',

                    // For the content of the text field
                    displayTpl: '{abbr} - {name}',

                    //editable: false,  // disable typing in the text field                  

                    store: [
                        { abbr: 'AL', name: 'Developemnt_System' },
                        { abbr: 'AK', name: 'Testing_System' },
                        { abbr: 'AZ', name: 'Production_System' }
                    ]
                  //  scale: 'large',
                   // ui: 'soft-green',
                    //iconAlign: 'right',
                   // iconCls: 'x-fa fa-angle-right'
                }  
            ]
        }
    ],

    initComponent: function() {
        this.addCls('user-login-register-container');
        this.callParent(arguments);
    }
});
