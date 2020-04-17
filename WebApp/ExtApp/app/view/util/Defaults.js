
Ext.define('EddkaApp.view.util.Defaults',{
  //  extend: 'Ext.panel.Panel',

    singleton: true,

    BaseUrl: 'http://localhost:57410',

    getFullUrl: function (path) {
        return BaseUrl + path;
    }
});
