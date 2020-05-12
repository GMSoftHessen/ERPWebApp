Ext.define('App.view.main.TreeListModel', {
    extend: 'Ext.app.ViewModel',

    alias: 'viewmodel.tree-list',

    data: {
        englisch: {
            title : 'englich'
        },
         deutsch: {
             title: 'deutsch'
        }
    },

    formulas: {

        languege: function (name) {

            return 'englisch.title';
        },
        selectionText: function (get) {
            var selection = get('treelist.selection'),
                path;
            if (selection) {
                path = selection.getPath('text');
                path = path.replace(/^\/Root/, '');
                return 'Selected: ' + path;
            } else {
                return 'No node selected';
            }
        },

        selectionXtype: function (get) {
            var selection = get('treelist.selection'),
                xtype;
            if (selection) {
                xtype = selection.get('xtype');
                
                return xtype;
            } else {
                return 'No xtype';
            }
        }
    },

    stores: {
        englisch: {
            title: 'englich'
        },
        deutsch: {
            title: 'deutsch'
        },
        navItems: {
            type: 'tree',
            root: {
                expanded: true,
                children: [{
                    text: 'Administration',
                    iconCls: 'x-fa fa-home',
                    children: [{
                        text: 'Lokalisation',
                        iconCls: 'x-fa fa-inbox',
                         viewType: 'home', 
                         routeId: 'home',
                        leaf: true
                    }, {
                        text: 'Währungen',
                        iconCls: 'x-fa fa-database',
                        viewType: 'sys-currency',                         
                        leaf: true                      
                    
                    }]
                }, {
                    text: 'Finanzwesen',
                    iconCls: 'x-fa fa-user',
                    children: [{
                        text: 'Customer',
                        xtype: 'sales-customer',
                        iconCls: 'x-fa fa-tag',
                        leaf: true
                    }, {
                        text: 'Inactive',
                        iconCls: 'x-fa fa-trash',
                        leaf: true
                    }]
                }, {
                    text: 'Verkauf',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                }, {
                    text: 'Einkauf',
                    iconCls: 'x-fa fa-wrench',
                    children: [{
                        text: 'Sharing',
                        iconCls: 'x-fa fa-share-alt',
                        leaf: true
                    }, {
                        text: 'Notifications',
                        iconCls: 'x-fa fa-flag',
                        leaf: true
                    }, {
                        text: 'Network',
                        iconCls: 'x-fa fa-signal',
                        leaf: true
                    }]
                },
                {
                    text: 'Geschäftspartner',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                },
                {
                    text: 'Bankenabwicklung',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                },
                {
                    text: 'Lagerverwaltung',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                },
                {
                    text: 'Produktion',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                },
                {
                    text: 'Materialbedarfsplannung',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                },
                {
                    text: 'Service',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                },
                {
                    text: 'Personal',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                },
                {
                    text: 'Berichtauswahl',
                    iconCls: 'x-fa fa-group',
                    leaf: true
                }


                ]
            }
        }
    }
});