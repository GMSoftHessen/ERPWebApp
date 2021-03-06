
Ext.define('App.view.system.currency.CurrencyView', {
    extend: 'Ext.form.Panel',
    xtype: 'sys-currency',
    requires: [
        'Ext.grid.*',
        'Ext.form.*',
        'Ext.layout.container.Column',        
        'App.view.system.currency.CurrencyViewController',
        'App.view.system.currency.CurrencyViewModel'
        
    ],

    controller: 'system-currency-currencyview',
    viewModel: {
        type: 'system-currency-currencyview'
    },

    layout: 'vbox',
    items: [
        {
            //translation :App.Language,
            //bind: {
            //    html: '{englisch.title}'
            //},
            html: '_()' //App.Language.test100[App.Language.currentLocale]
        }
        , {
            html: App.Language.test100[App.Language.currentLocale]
        }

    ]
});
