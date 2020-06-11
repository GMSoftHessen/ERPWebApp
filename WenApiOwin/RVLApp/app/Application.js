
//function loadLocale()  {
//    var lang = localStorage ? (localStorage.getItem('user-lang') || 'en') : 'en',
//        file = Ext.util.Format.format("resources/locale/{0}.js", lang);
//    Ext.Loader.loadScript({
//        url: file, onError: function () {
//            alert('Error loading locale file. Please contact system administrator.');
//        }
//        , onLoad: function () {
//            console.log(lang);
//        }
//    });
//}



//loadLocale();




Ext.define('App.Application', {
    extend: 'Ext.app.Application',

    name: 'App',

    requires: [
        'App.overrides.tree.ColumnOverride'
    ],

    controllers: [      
        'Menu'
    ],
   

    //init: function () {
        

        
    //    //var me = this;
    //    //me.splashscreen = Ext.getBody().mask(
    //    //    'Loading appliaction', 'splashscreen'
    //    //);
      
    //    //me.splashscreen.next().fadeOut({
    //    //    duration: 1000,
    //    //    remove: true,
    //    //    listeners: {
    //    //        afteranimate: function (el, startTime, eOpts) {
    //    //            Ext.widget('login-dialog'); 
    //    //        }
    //    //    }
    //    //});
       
       
    //},

    launch: function () {
       // Ext.tip.QuickTipManager.init();

     Ext.widget('login-dialog');
    },

    //quickTips: false,
    //platformConfig: {
    //    desktop: {
    //        quickTips: true
    //    }
    //},

    //onAppUpdate: function () {
    //    Ext.Msg.confirm('Application Update', 'This application has an update, reload?',
    //        function (choice) {
    //            if (choice === 'yes') {
    //                window.location.reload();
    //            }
    //        }
    //    );
    //}
});
