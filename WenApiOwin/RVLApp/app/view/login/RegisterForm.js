Ext.define('App.view.login.RegisterForm', {

    extend: 'Ext.form.Panel',
    xtype: 'form-register',


    requires: [
        'App.view.login.RegisterFormController',
        'App.view.login.RegisterFromViewModel',
    ],

    controller: 'RegisterFormController',
    viewModel: 'RegisterFromViewModel',
   

    frame: true,
    title: 'Register',
    bodyPadding: 10,
    scrollable: true,
    width: 355,
    

    fieldDefaults: {
        labelAlign: 'right',
        labelWidth: 115,
        msgTarget: 'side'
    },

    items: [{
        xtype: 'fieldset',    
        title: 'User Info',
        defaultType: 'textfield',
        defaults: {
            anchor: '100%'
        },

        items: [
           
            { allowBlank: false, fieldLabel: 'User ID', name: 'Email', emptyText: 'user id', bind: '{RegisterFromViewModel.Email}' },
            { allowBlank: false, fieldLabel: 'Password', name: 'Password', emptyText: 'password', inputType: 'password', bind: '{RegisterFromViewModel.Password}' },
            { allowBlank: false, fieldLabel: 'Verify', name: 'ConfirmPassword', emptyText: 'password', inputType: 'password', bind: '{RegisterFromViewModel.ConfirmPassword}'}
        ]
   /* }, {
        xtype: 'fieldset',
        title: 'Contact Information',

        defaultType: 'textfield',
        defaults: {
            anchor: '100%'
        },

        items: [{
            fieldLabel: 'First Name',
            emptyText: 'First Name',
            name: 'first'
        }, {
            fieldLabel: 'Last Name',
            emptyText: 'Last Name',
            name: 'last'
        }, {
            fieldLabel: 'Company',
            name: 'company'
        }, {
            fieldLabel: 'Email',
            name: 'email',
            vtype: 'email'
        }, {
            xtype: 'combobox',
            fieldLabel: 'State',
            name: 'state',
            store: {
                type: 'states'
            },
            valueField: 'abbr',
            displayField: 'state',
            typeAhead: true,
            queryMode: 'local',
            emptyText: 'Select a state...'
        }, {
            xtype: 'datefield',
            fieldLabel: 'Date of Birth',
            name: 'dob',
            allowBlank: false,
            maxValue: new Date()
        }]*/
    }],

    buttons: [{
        text: 'Register',
        disabled: true,
        formBind: true,
        listeners: {
            click: 'onButtonClickDoRegisteration'
        }
    }]
});