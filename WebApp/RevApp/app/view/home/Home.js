
Ext.define('App.view.home.Home',{
    extend: 'Ext.panel.Panel',
    xtype : 'home',
    requires: [
        'App.view.home.HomeController',
        'App.view.home.HomeModel'
    ],

    controller: 'home-home',
    viewModel: {
        type: 'home-home'
    },

    html: 'Hello, World!!'
});
