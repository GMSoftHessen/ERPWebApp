
Ext.define('EddkaApp.view.sales.customer.CustomerEditHeader', {
    extend: 'Ext.panel.Panel',
    xtype: 'sales-customerEditHeader',

    requires: [
        'Ext.layout.HBox'
    ],

    bodyPadding: 10,
    defaultType: 'panel',
   
   

    layout: {
        type: 'hbox'
    },

    defaults: {
        bodyPadding: 10
        
    },

    items: [{
        margin: '0 10 0 0',
        width: '500',
        items: [
            {
                xtype: 'fieldset',
                items: [{
                    xtype: 'textfield',
                    name: 'name',
                    label: 'Name',
                    placeholder: 'Tom Roy',
                    autoCapitalize: true,
                    required: true,
                    clearable: true
                }, {
                    xtype: 'textfield',
                    name: 'name2',
                    label: 'Name',
                    placeholder: 'Tom Roy',
                    autoCapitalize: true,
                    required: true,
                    clearable: true
                },
                {
                        xtype: 'textfield',
                        name: 'name12',
                        label: 'Name',
                        placeholder: 'Tom Roy',
                        autoCapitalize: true,
                        required: true,
                        clearable: true
                }, {
                        xtype: 'textfield',
                        name: 'name21',
                        label: 'Name',
                        placeholder: 'Tom Roy',
                        autoCapitalize: true,
                        required: true,
                        clearable: true
                }

                ]

            }
        ]

    }, {
        margin: '0 10 0 0',
        width: '500',
        items: [
            {
                xtype: 'fieldset',
                items: [{
                    xtype: 'textfield',
                    name: 'name1',
                    label: 'Name',
                    placeholder: 'Tom Roy',
                    autoCapitalize: true,
                    required: true,
                    clearable: true
                }, {
                    xtype: 'textfield',
                    name: 'name3',
                    label: 'Name',
                    placeholder: 'Tom Roy',
                    autoCapitalize: true,
                    required: true,
                    clearable: true
                }

                ]

            }
        ]
    }, {
            width: '500',
            items: [
                {
                    xtype: 'fieldset',
                    items: [{
                        xtype: 'textfield',
                        name: 'name4',
                        label: 'Name',
                        placeholder: 'Tom Roy',
                        autoCapitalize: true,
                        required: true,
                        clearable: true
                    }, {
                        xtype: 'textfield',
                        name: 'name5',
                        label: 'Name',
                        placeholder: 'Tom Roy',
                        autoCapitalize: true,
                        required: true,
                        clearable: true
                    }

                    ]

                }
            ]
    }]
});