Ext.define('EddkaApp.view.sales.customer.CustomerRoot', {
    extend: 'Ext.container.Container',
    xtype: 'sales-customer',
    id: 'sales-customer',



    layout: 'vbox',
    fullscreen: true,
    items: [{
        xtype: 'sales-CustomerToolbar'
    },
    {
        layout: 'fit',
        xtype: 'panel',
        id: 'customerview-carousel',
        flex: 2,


        items:
            [{
                xtype: 'sales-customerEditContainer',
               
            }
                //, {
                //    xtype: 'sales-customerview',
                //    id: 'card-map'
                //}
            ]

    }]
});