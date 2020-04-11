Ext.define('EddkaApp.view.sales.customer.CustomerGrid', {
    extend: 'Ext.grid.Grid',
    xtype: 'customer-list',
    id: 'customer-listId',
    requires: [
        'EddkaApp.store.sales.Customer',
        'Ext.grid.plugin.Exporter'
    ],
    fullscreen: true, 
    store: {
        type: 'customer'
    },   
   


    columns: [
       { text: 'CustomerId', dataIndex: 'CustomerId' },
	   { text: 'FirstName', dataIndex: 'FirstName' },
	   { text: 'LastName', dataIndex: 'LastName' },
	   { text: 'Company', dataIndex: 'Company' },
	   { text: 'Address', dataIndex: 'Address' },
	   { text: 'City', dataIndex: 'City' },
	   { text: 'State', dataIndex: 'State' },
	   { text: 'Country', dataIndex: 'Country' },
	   { text: 'PostalCode', dataIndex: 'PostalCode' },
	   { text: 'Phone', dataIndex: 'Phone' },
	   { text: 'Fax', dataIndex: 'Fax' },
	   { text: 'Email', dataIndex: 'Email' }
    ],

    listeners: {
        select: 'onItemSelected'
    }

});