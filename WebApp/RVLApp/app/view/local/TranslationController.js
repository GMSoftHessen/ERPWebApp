Ext.define('App.view.locale.TranslationController', {
    extend: 'Ext.app.ViewController',
    alias: 'controller.translation',

    init: function () {
        var lang = localStorage ? (localStorage.getItem('user-lang') ||
            'en') : 'en',
            button = this.getView();
        button.setIconCls(lang); //#1
        if (lang == 'en') { //#2
            button.setText('English');
        } else if (lang == 'de') {
            button.setText('Deutsch');
        } else {
            button.setText('Francais');
           
           
           
        }
    },

    onMenuItemClick: function (item, e, options) {
        Ext.log('test');
       
        var menu = this.getView(); 
        menu.setIconCls(item.iconCls);
        menu.setText(item.text); 
        localStorage.setItem("user-lang", item.iconCls); 
        translations = getTranslations();
        //this.loadLocale();
        window.location.reload();
        
    },

    //loadLocale: function ()  {
    //    var lang = localStorage ? (localStorage.getItem('user-lang') || 'en') : 'en',
    //    file = Ext.util.Format.format("resources/locale/{0}.js", lang);
    //    Ext.Loader.loadScript({
    //        url: file, onError: function () {
    //            alert('Error loading locale file. Please contact system administrator.');
    //        }
    //        , onLoad: function () {
    //            console.log(lang);
    //        }
    //    });
    //}





});