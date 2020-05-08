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
            lookupReference: 'treelist-with-nav',
            bind: '{navItems}'
        }],
        listeners: {
            click: {
                element: 'el', //bind to the underlying el property on the panel
                fn: function () {
                    mainCard = Ext.getCmp('Center');
                    mainLayout = mainCard.getLayout();

                    Ext.getCmp('Center').setActiveItem(Ext.create({ xtype: 'sys-currency' }));  
                    console.log('click el');
                }
            }
        }

    }, {
        title: 'Favorites',

        html: 'Badges <em>(like the 4, below)</em> can be added by setting <code>badgeText</code> when creating a tab or by using <code>setBadgeText()</code> on the tab later.',

       iconCls: 'x-fa fa-star'

    }, {
        title: 'History',


        iconCls: 'x-fa fa-download'
    }]
});