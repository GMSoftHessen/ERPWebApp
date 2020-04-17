Ext.define('EddkaApp.store.sales.Customer', {
    extend: 'Ext.data.Store',

    alias: 'store.customer',

    model: 'EddkaApp.model.Customer',

        
    proxy: {
        type: 'ajax',
        url: EddkaApp.view.util.Defaults.BaseUrl +'/api/AllCustomers',
        reader: {
            type: 'json'
           // rootProperty: ''
        }
    },
    remoteFilter: true,
    remoteSort: true,
    autoLoad: true
});



