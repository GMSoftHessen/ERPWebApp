
Ext.define('EddkaApp.view.main.Main', {
    extend: 'Ext.container.Container',
    xtype: 'app-main',

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
      
        title: 'Hauptmen�',
        docked: 'top',
        minHeight: 100,
        resizable: {           
            edges: 'south',
            split: true
        }
    },
    {
      //  title: 'Unresizable region',     
        flex: 2,
        items: [{
            xtype: 'sales-customer'            
        }],
    },
    {
        title: 'Hauptmenue',
        docked: 'left',   
         flex: 1,
        minWidth: 300,
        collapsible:'left',
        resizable: {         
            edges: 'east',
            split: true
        } ,  
        items: [{
            xtype: 'main-tabs'
           
        }]
    }]
});
