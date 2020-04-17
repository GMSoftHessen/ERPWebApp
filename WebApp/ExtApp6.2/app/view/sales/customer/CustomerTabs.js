Ext.define('Revolution.view.sales.customer.CustomerTabs', {
    extend: 'Ext.tab.Panel',
    xtype: 'customerTabs',

    
    fullscreen: true, 
    tabBar: {
        layout: {
            pack: 'start',
            overflow: 'scroller'
        }
    },
    defaults: {
        scrollable: true,   
        userCls: 'card',
        tab: {
            minWidth: 100
        }
    },
    items: [{
        title: 'Kunden Übersicht',
        layout: 'fit',
        items: [{
            xtype: 'customer-list'
              
        }],

    }]
});