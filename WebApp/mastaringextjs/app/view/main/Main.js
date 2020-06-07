Ext.define('Packt.view.main.Main', {
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
        'Packt.view.main.Header',
        'Packt.view.main.Footer',
        'Packt.view.main.Panel',
        'Packt.view.main.MainController',
        'Packt.view.main.MainModel'
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
        xtype: 'container',
        region: 'west',
        width: 200,
        split: true
    }]
});
