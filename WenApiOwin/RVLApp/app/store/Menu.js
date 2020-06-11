
Ext.define('App.store.Menu', {
    extend: 'Ext.data.Store',
    requires: [
        'App.util.Util' 
    ],
    model: 'App.model.menu.Accordion', 
    //autoLoad:true,
    proxy: {
        type: 'ajax', 
        url: App.util.Util.BaseUrl + 'Menus',  
        reader: { 
            type: 'json',           
            rootProperty: 'MenuDTO'
        },
        listeners: {
            exception: function (proxy, response, operation) { 
                App.util.Util.showErrorMsg(response.responseText);
            }
        }
    }
});