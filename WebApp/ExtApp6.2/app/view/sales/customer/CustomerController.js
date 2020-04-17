Ext.define('Revolution.view.sales.customer.CustomerController', {
    extend: 'Ext.app.Controller',

    alias: 'controller.customer',
    requires: [
        'Revolution.store.sales.Customer'
     
    ],

    control: {
        '#': {
            reset: 'refresh'
        }
    },

    refresh: function () {
        var vm = this.getViewModel();
        vm.getStore('customer').reload();
      
    },
});
