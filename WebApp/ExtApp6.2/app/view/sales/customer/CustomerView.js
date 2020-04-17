Ext.define('Revolution.view.sales.customer.CustomerView', {
    extend: 'Ext.container.Container',
    xtype: 'sales-customerview',

    requires: [
        'Ext.panel.Resizer',
        'Ext.panel.Collapser',
        'Ext.Toolbar'
    ],

    layout: {
        type: 'vbox',
        align: 'stretch'
    },

    defaults: {
        xtype: 'panel',
        border: true
    },

    items: [{
        docked: 'top',
        height: 250,
        minHeight: 100,
        resizable: {
            edges: 'south',
            split: true
        },
        items: [{
            xtype: 'CustomerFilter'
        }]
    },
    {
        xtype: 'customerTabs'

    }]

});