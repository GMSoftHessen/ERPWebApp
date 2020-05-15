/**
 * The main application class. An instance of this class is created by app.js when it
 * calls Ext.application(). This is the ideal place to handle application launch and
 * initialization details.
 */
Ext.define('Packt.Application', {
    extend: 'Ext.app.Application',

    name: 'Packt',

    views: [
        'login.Login'
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
    //,
    //launch: function () {

    //}
  
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
