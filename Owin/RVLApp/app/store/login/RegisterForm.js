
Ext.define('App.store.login.RegisterForm', {
    extend: 'Ext.data.Store',
    requires: [
        'App.util.Util' 
    ],
    model: 'App.model.login.RegisterForm', 
    
    proxy: {
        type: 'ajax', 
        url: App.util.Util.BaseUrl + 'Register/Account', 
        reader: { 
            type: 'json',           
            rootProperty: 'Data'
        },
        listeners: {
            exception: function (proxy, response, operation) { 
                App.util.Util.showErrorMsg(response.responseText);
            }
        }
    }
});