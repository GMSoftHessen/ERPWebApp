Ext.define('EddkaApp.store.sales.Customer', {
    extend: 'Ext.data.Store',

    alias: 'store.customer',

    model: 'EddkaApp.model.Customer',

        
    proxy: {
        type: 'ajax',
        url: 'http://localhost:57410/api/AllCustomers',
        reader: {
            type: 'json'
           // rootProperty: ''
        }
    },
    autoLoad: true
});



