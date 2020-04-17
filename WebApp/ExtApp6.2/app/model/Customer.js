Ext.define('Revolution.model.Customer', {
    extend: 'Ext.data.Model',

    fields: [
        { name: 'CustomerId', type: 'int' },
        { name: 'FirstName', type: 'string' },
        { name: 'LastName', type: 'string' },
        { name: 'Company', type: 'string' },
        { name: 'Address', type: 'string' },
        { name: 'City', type: 'string' },
        { name: 'State', type: 'string' },
        { name: 'Country', type: 'string' },
        { name: 'PostalCode', type: 'string' },
        { name: 'Phone', type: 'string' },
        { name: 'Fax', type: 'string' },
        { name: 'Email', type: 'string' }
    ]

    /*
    Uncomment to add validation rules
    validators: {
        age: 'presence',
        name: { type: 'length', min: 2 },
        gender: { type: 'inclusion', list: ['Male', 'Female'] },
        username: [
            { type: 'exclusion', list: ['Admin', 'Operator'] },
            { type: 'format', matcher: /([a-z]+)[0-9]{2,3}/i }
        ]
    }
    */

    /*
    Uncomment to add a rest proxy that syncs data with the back end.
    proxy: {
        type: 'rest',
        url : '/users'
    }
    */
});