
Ext.define('App.Application', {
    extend: 'Ext.app.Application',

    name: 'App',

    views: [
        'authentication.Login'
    ],
    controllers: [
        //'Root'
    ],
    stores: [
    ],
    init: function () {
        var me = this;
        //me.splashscreen = Ext.getBody().mask(
        //    'Loading appliaction', 'splashscreen'
        //);

        //me.splashscreen.next().fadeOut({
        //    duration: 1000,
        //    remove: true,
        //    listeners: {
        //        afteranimate: function (el, startTime, eOpts) {
        //            Ext.widget('login-dialog'); 
        //        }
        //    }
        //});

        Ext.widget('login-dialog');
    },

    launch: function () {
        Ext.tip.QuickTipManager.init();
    },

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
