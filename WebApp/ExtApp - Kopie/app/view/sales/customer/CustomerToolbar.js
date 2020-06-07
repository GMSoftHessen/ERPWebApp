Ext.define('EddkaApp.view.sales.customer.CustomerToolbar', {
    extend: 'Ext.Panel',

    xtype: 'sales-CustomerToolbar',
    
    height: '50', 
    tbar: [{
        text: 'Neu',
        ui: 'action'
    }, {
        xtype: 'spacer'
    }, {
        xtype: 'segmentedbutton',
        allowDepress: true,
        items: [{
            text: 'Übersicht',
            pressed: true,
            handler: function () {
                Ext.getCmp('customerview-carousel').setActiveItem(0);
            }
        }, {
            text: 'Bearbeitung',
            handler: function () {
                //Ext.getCmp('customerview-carousel')
                //getLayout().setAnimation({ type: 'Slide', direction: 'Right', duration: 300 });
                Ext.getCmp('customerview-carousel').setActiveItem(1);
            }
        }]
    }, {
        xtype: 'spacer'
    }, {
        text: 'Exportieren nach',
        ui: 'action',
        handler: function (btn) {

            var cfg = Ext.merge({
                title: 'Grid export demo',
                fileName: 'GridExport' + '.' + (btn.cfg.ext || btn.cfg.type)
            }, btn.cfg);

            this.getView().saveDocumentAs(cfg);

            //Ext.getCmp('customer-listId').;
        }
    }]
});