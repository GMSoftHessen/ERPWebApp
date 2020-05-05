
Ext.define('App.view.system.currency.CurrencyView',{
    extend: 'Ext.panel.Panel',
    xtype : 'sys-currency',
    requires: [
        'App.view.system.currency.CurrencyViewController',
        'App.view.system.currency.CurrencyViewModel'
    ],

    controller: 'system-currency-currencyview',
    viewModel: {
        type: 'system-currency-currencyview'
    },

    html: 'Hello, World!!'
});
