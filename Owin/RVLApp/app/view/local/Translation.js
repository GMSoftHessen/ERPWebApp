Ext.define('App.view.locale.Translation', {
    extend: 'Ext.button.Split', 

    requires: [
        'App.view.locale.TranslationController'
    ],
    controller: 'translation',

    xtype: 'translation', 
    menu: { 
        xtype: 'menu', 
        defaults: {
            listeners: {
                click: 'onMenuItemClick'
            }
        },
        items: [
            {
                xtype: 'menuitem', 
                iconCls: 'de',
                text: 'Deutsch'
            },
            {
                xtype: 'menuitem', 
                iconCls: 'en',
                text: 'Englisch'
            },
            {
                xtype: 'menuitem', 
                iconCls: 'fr',
                text: 'Francais'
            }
        ]
    }
});