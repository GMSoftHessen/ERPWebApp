Ext.define('App.view.main.MainController', {
	extend: 'Ext.app.ViewController',

    alias: 'controller.MainControler',

    listen: {
        controller: {
            '#': {
                unmatchedroute: 'onRouteChange'
            }
        }
    },

    routes: {
        ':node': 'onRouteChange'
    },

    lastView: null,

    setCurrentView: function (hashTag) {
        hashTag = (hashTag || '').toLowerCase();
       
        mainLayout = Ext.getCmp('Center').getLayout();
        
        lastView = mainLayout.getActiveItem();
        if (lastView.xtype != hashTag) {
            
            lastView.destroy();
            newView = Ext.create({
                xtype: hashTag
            });

            Ext.log(newView.xtype);
        }

        

        Ext.suspendLayouts();
        mainLayout.setActiveItem(Ext.getCmp('Center').add(newView));
        Ext.resumeLayouts(true);

       /* store = Ext.getCmp('treelistId').getStore(),
        node = store.findNode('routeId', hashTag) ||
            store.findNode('viewType', hashTag),
            navigationList.setSelection(node);

        if (newView.isFocusable(true)) {
            newView.focus();
        }*/
        
    },

    onMainViewRender: function () {
        if (!window.location.hash) {
            this.redirectTo("home");
        }
    },

    onRouteChange: function (id) {      
        this.setCurrentView(id);
    }, 

    onNavigationTreeSelectionChange: function (tree, node) {
         var to = node && (node.get('routeId') || node.get('viewType'));       
         if (to) {
            this.redirectTo(to);
        }
    },
});