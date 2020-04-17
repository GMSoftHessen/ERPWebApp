Ext.define('Revolution.view.sales.customer.Customer', {
	extend: 'Ext.container.Container',
	xtype: 'sales-customer',
	id: 'sales-customer',
	requires : [
        'Ext.Panel',        
        'Ext.Anim'
	],

	layout: 'vbox',
	fullscreen: true,
	items: [{
		height: '50',
		xtype: 'panel',
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
	},
    {
        xtype: 'carousel',
    
    	id: 'customerview-carousel',
    	flex: 2,

    	layout: 'card',
    	items:
            [{
               // xtype: 'app-calendar'
                xtype: 'sales-customerview',
                id: 'card-map'
            },
             {
                 html :'test'
               
            }]

    }]
});