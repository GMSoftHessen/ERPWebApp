Ext.define('EddkaApp.view.sales.customer.CustomerViewGrid', {
    extend: 'Ext.grid.Grid',
    xtype: 'customer-list',
    id: 'customer-listId',
    requires: [
        'EddkaApp.store.sales.Customer',
        'Ext.grid.plugin.Exporter',
        'Ext.grid.plugin.RowExpander'
    ],


    fullscreen: true, 
    rowNumbers: true,
    plugins: {
        rowexpander: true
    },
    store: {
        type: 'customer'
    },   
   


    columns: [
       { text: 'CustomerId', dataIndex: 'CustomerId' },
	   { text: 'FirstName', dataIndex: 'FirstName' },
	   { text: 'LastName', dataIndex: 'LastName' },
	   { text: 'Company', dataIndex: 'Company' },
       { text: 'Address', dataIndex: 'Address', flex: 1 },
	   { text: 'City', dataIndex: 'City' },
	   { text: 'State', dataIndex: 'State' },
	   { text: 'Country', dataIndex: 'Country' },
	   { text: 'PostalCode', dataIndex: 'PostalCode' },
	   { text: 'Phone', dataIndex: 'Phone' },
	   { text: 'Fax', dataIndex: 'Fax' },
	   { text: 'Email', dataIndex: 'Email' , flex:1}
    ],

    listeners: {
        select: 'onItemSelected'
    }

});