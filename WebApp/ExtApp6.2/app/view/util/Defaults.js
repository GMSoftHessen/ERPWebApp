
Ext.define('Revolution.view.util.Defaults',{
  //  extend: 'Ext.panel.Panel',

    singleton: true,

    BaseUrl: 'http://localhost:57410',

    getFullUrl: function (path) {
        return BaseUrl + path;
    }
});
