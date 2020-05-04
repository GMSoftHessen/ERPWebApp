Ext.define('EddkaApp.view.sales.customer.CustomerViewFilterContainer', {
    extend: 'Ext.carousel.Carousel',
    xtype: 'CustomerFilter',
    
    fullscreen: true,  

    defaults: {
        layout: 'center'
    },

    items: [{
        html: '<p>Swipe left to show the next card&hellip;</p>',
        cls: 'stock-image stock-one-background'
    }, {
        html: '<p>You can also tap on either side of the indicators.</p>',
        cls: 'stock-image stock-two-background'
    }, {
        html: 'Card #3',
        cls: 'stock-image stock-three-background'
    }]
});