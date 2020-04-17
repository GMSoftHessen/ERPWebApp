Ext.define('Revolution.view.main.Tabs', {
    extend: 'Ext.tab.Panel',
    xtype: 'main-tabs',

    height: '100%',  

    tabBar: {
        docked: 'bottom',
        overflow: 'scroller',
        defaults: {
            iconAlign: 'top'
        }
    },

    defaults: {
        scrollable: true,
        layout: 'center'
       
    },
    viewModel: {
        type: 'tree-list'
    },

    items: [{
        title: 'Application',
        layout: {
            type: 'vbox',
            align: 'stretch'
        },
        cls: 'card',
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
        cls: 'card',
        iconCls: 'x-fa fa-star'
        //  badgeText: '4'
    }, {
        title: 'History',
        id: 'tab3',
        html: 'Badge labels will truncate if the text is wider than the tab.',
        //  badgeText: 'Overflow test',
        cls: 'card',
        iconCls: 'x-fa fa-download'
    }]
});