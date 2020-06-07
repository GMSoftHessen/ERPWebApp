
Ext.define('EddkaApp.view.sales.customer.CustomerEditContainer',{
    extend: 'Ext.container.Container',
    xtype: 'sales-customerEditContainer',


    requires: [
        'Ext.panel.Panel',
        'Ext.Toolbar'
    ],

    padding: '0 0 50 0',
    
    scrollable: true,
  
    
    items: [{
        xtype: 'panel',
        
        title: 'Kunden-Stammdaten',    
        items: [{
            xtype: 'sales-customerEditHeader',  
            scrollable: true,
            padding: '0 0 30 35' 
        }]
    }]
   
});
