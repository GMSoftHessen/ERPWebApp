Ext.define('App.model.base.system.CurrenciesModelBase', {
    extend: 'Ext.data.Model',

    //  nummer - date

    fields: [
        { name: 'CodeIso', type: 'string' },
        { name: 'Designation', type: 'string' },
        { name: 'Unicode', type: 'string' },
        { name: 'Active', type: 'boolean', defaultValue: true },
        { name: 'Id', type: 'int' },

    ],

    validators: {
        CodeIso: 'presence',
        Designation: 'presence',

        Active: 'presence',

    },
    
    proxy: {
        type: 'ajax',
        api: {
            create: App.view.util.Defaults.BaseUrl + '/api/Currencies',
            update: App.view.util.Defaults.BaseUrl + '/api/Currencies',
            destroy: App.view.util.Defaults.BaseUrl + '/api/Currencies',
            read: App.view.util.Defaults.BaseUrl + '/api/Currencies'
        },
       
        reader: {
            type: 'json'
            // rootProperty: ''
        }
    },

});