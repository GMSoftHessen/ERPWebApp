
Ext.define('Revolution.view.util.Errors',{
  //  extend: 'Ext.panel.Panel',
   
    requires: [
        'EddkaApp.view.util.ErrorsController',
        'EddkaApp.view.util.ErrorsModel',
        'Ext.Toast'
    ],

    controller: 'util-errors',
    viewModel: {
        type: 'util-errors'
    }

   
});
