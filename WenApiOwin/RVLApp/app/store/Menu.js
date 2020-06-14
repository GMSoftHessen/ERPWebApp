
Ext.define('App.store.Menu', {
    extend: 'Ext.data.Store',
    requires: [
        'App.store.Util' 
    ],
    model: 'App.model.menu.Accordion', 
    //autoLoad:true,
    proxy: {
        type: 'ajax', 
        url: 'http://localhost:61443/api/' + 'Menus',  
        reader: { 
            type: 'json',           
            rootProperty: 'MenuDTO'
        },
        listeners: {
            exception: function (proxy, response, operation) { 
                App.store.Util.showErrorMsg(response.responseText);
            }
        }
    }
});