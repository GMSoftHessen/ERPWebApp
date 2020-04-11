Ext.define('EddkaApp.view.sales.customer.CustomerController', {
    extend: 'Ext.app.Controller',

    alias: 'controller.customer',
    requires: [
        'EddkaApp.store.sales.Customer'
     
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
