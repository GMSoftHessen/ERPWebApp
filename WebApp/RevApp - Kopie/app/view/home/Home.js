
Ext.define('App.view.home.Home',{
    extend: 'Ext.panel.Panel',
    xtype : 'home',
    requires: [
        'App.view.home.HomeController',
        'App.view.home.HomeModel',
        'App.view.base.Config'
    ],

    controller: 'home-home',
    viewModel: {
        type: 'home-home'
    },

    //bind: {
    //    html: _() + 'Hello, World!!'
    //},
    
   // html: App.global._
    
});
