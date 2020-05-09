
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

    
         html: 'Währungen'
});
