Ext.define('App.global', {
    singleton: true,
    user_guid: null,
    is_admin: false,
    something: 'else'
    _: function () {
        //var store = Ext.getStore('locales')
        //    , rec = store.findRecord('textId', textId)
        //    ;
        return 'eeeeee';//rec ? rec.get(MyApp.currentLocale) : text;
    }
    
});
Ext.define('App.Application', {
    extend: 'Ext.app.Application',

    name: 'App',

    quickTips: false,
    platformConfig: {
        desktop: {
            quickTips: true
        }
    },

    onAppUpdate: function () {
        Ext.Msg.confirm('Application Update', 'This application has an update, reload?',
            function (choice) {
                if (choice === 'yes') {
                    window.location.reload();
                }
            }
        );
    }
});
