
Ext.define('App.view.main.Main', {
    extend: 'App.view.base.Config',
    xtype: 'app-main',
    requires: [
        'Ext.layout.container.Border'
        
    ],
 
    controller: 'MainControler',
    viewModel: {
        type: 'tree-list'
    },
    listeners: {
        render: 'onMainViewRender'
    },
    layout: 'border',
    width: 500,
    height: 400,
    cls: Ext.baseCSSPrefix + 'shadow',
    
    bodyBorder: false,
    translation: App.Language,
    defaults: {
        collapsible: true,
        split: true,
        bodyPadding: 10
    },

    items: [     
        {
            title: 'Navigation',
            region: 'west',
            floatable: false,
            margin: '5 0 0 0',
            width: 350,
            minWidth: 100,
            maxWidth: 350,
            xtype: 'main-tabs'
        },
        {
            itemId: 'Center',
            id: 'Center',
            bind: {
                title: '{languege}'
            },
            collapsible: false,
            region: 'center',
            margin: '5 0 0 0',
            reference: 'mainCardPanel',
            layout: {
                type: 'card'
            },
            items: [{        
            }]
           
        }
    ]
    
});
