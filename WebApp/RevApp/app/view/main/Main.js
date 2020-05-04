/**
 * This class is the main view for the application. It is specified in app.js as the
 * "mainView" property. That setting automatically applies the "viewport"
 * plugin causing this view to become the body element (i.e., the viewport).
 *
 * TODO - Replace this content of this view to suite the needs of your application.
 */
Ext.define('App.view.main.Main', {
    extend: 'Ext.panel.Panel',
    xtype: 'app-main',
    requires: [
        'Ext.layout.container.Border'
    ],
    profiles: {
        classic: {
            itemHeight: 100
        },
        neptune: {
            itemHeight: 100
        },
        graphite: {
            itemHeight: 120
        },
        'classic-material': {
            itemHeight: 120
        }
    },
    layout: 'border',
    width: 500,
    height: 400,
    cls: Ext.baseCSSPrefix + 'shadow',

    bodyBorder: false,

    defaults: {
        collapsible: true,
        split: true,
        bodyPadding: 10
    },

    items: [     
        {
            title: 'Navigation',
            region: 'west',
            floatable: false,
            margin: '5 0 0 0',
            width: 270,
            minWidth: 100,
            maxWidth: 350,
            xtype: 'main-tabs'
        },
        {
            title: 'Main Content',
            collapsible: false,
            region: 'center',
            margin: '5 0 0 0',
            html: '<h2>Main Page</h2><p>This is where the main content would go</p>'
        }
    ]
    
});
