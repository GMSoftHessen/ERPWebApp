Ext.define('App.model.login.Register', {
    extend: 'Ext.data.Model',
  
    fields: [
        'Id',
        'Email',
        'Password',
        'ConfirmPassword'
    ],

     proxy: {
        type: 'rest',
        url: 'http://localhost:61443/api/' + 'Account/Register'
        
    },
    reader: {
        type: 'json',
        rootProperty: 'data'
    },
    writer: { 
        type: 'json',
        writeAllFields: true,
        encode: true,
        rootProperty: 'data',
        allowSingle: false
    },
   
});
