Ext.define('App.view.login.RegisterFromViewModel', {
    extend: 'Ext.app.ViewModel',
    alias: 'viewmodel.RegisterFromViewModel',
    requires: [
        'App.store.login.Registers'      
    ],
     stores: {
         registers: {

             fields: [
                 'Email',
                 'Password',
                 'ConfirmPassword'
             ],

             proxy: {
                 type: 'rest',
                 url: 'http://localhost:61443/api/Account/Register',

                 reader: {
                     type: 'json',
                 },
                 writer: {
                     type: 'json'
                 }

             },
            
           
         }
    }


});