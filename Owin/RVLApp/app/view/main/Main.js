Ext.define('App.view.main.Main', {
    extend: 'Ext.container.Container',
    plugins: 'viewport',
    xtype: 'app-main',

    controller: 'main',
    viewModel: {
        type : 'main'
    },
    layout: {
        type:'border'
    },
    requires: [ 
        'App.view.main.Header',
        'App.view.main.Footer',
        'App.view.main.Panel',
        'App.view.main.MainController',
        'App.view.main.MainModel'
    ],

    items: [{
        region: 'center',
        xtype: 'mainpanel'
    }, {
        xtype: 'appheader',
        region: 'north'
    }, {
        xtype: 'appfooter',
        region: 'south'
    }, {
        xtype: 'mainmenu',
        region: 'west'
    }]
});
