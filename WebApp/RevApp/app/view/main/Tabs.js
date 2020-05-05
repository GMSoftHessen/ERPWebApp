Ext.define('App.view.main.Tabs', {
    extend: 'Ext.tab.Panel',
    xtype: 'main-tabs',

    height: '100%',
    tabPosition: 'bottom',

    defaults: {
        scrollable: true,
        layout: 'center'

    },
   

    items: [{
        title: 'Application',
        layout: {
            type: 'vbox',
            align: 'stretch'
        },
        //  cls: 'card',
        iconCls: 'x-fa fa-info-circle',
        items: [{

            xtype: 'treelist',
            reference: 'treelist',
            ui: 'nav',
            scrollable: 'y',
            expanderFirst: false,
            //micro :true,
            lookupReference: 'treelist-with-nav',
            bind: '{navItems}'
        }],

    }, {
        title: 'Favorites',

        html: 'Badges <em>(like the 4, below)</em> can be added by setting <code>badgeText</code> when creating a tab or by using <code>setBadgeText()</code> on the tab later.',

       iconCls: 'x-fa fa-star'

    }, {
        title: 'History',


        iconCls: 'x-fa fa-download'
    }]
});