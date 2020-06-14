Ext.define('App.view.login.RegisterFormController', {
    extend: 'Ext.app.ViewController',
    alias: 'controller.RegisterFormController',

    requires: [
        'App.store.login.Registers',
        'App.view.login.CapsLockTooltip'
       
    ],

  
    onButtonClickDoRegisteration: function (button, e, options) {

        var newRecord = new App.model.login.Register();
      
        var record = this.getViewModel().get('RegisterFromViewModel');
        var store = this.getViewModel().get('registers');
        console.log(record);
     
        //var rw = {
        //    Id:'0',
        //    Email: 'r',
        //    Password: 'test',
        //    ConfirmPassword: 'test'
        //}
       // store.insert(0, record);
   
        store.add(record);
        //////store.insert();
        store.sync({
            callback: function (batch, options) {
                // ...
            },
            success: function (batch, options) {
                // ...
            },
            failure: function (batch, options) {
                record.id = 0;
            }
        });

        //var productModel = this.lookupReference('RegisterFieldset').getViewModel().data;

        //console.log(productModel)
        //productModel.commit();

      //  var store = this.getViewModel().data.registers;
      //  console.log(record)
      ////  record.save();

      //  var desc = this.lookupReference('RegisterFieldset').value.trim();
      //  if (desc != '') {
      //      store.add({
      //          desc: desc
      //      });
      //      store.sync();
       
      //  console.log(record)
      //  Ext.toast('Page saved');

       // var record = this.getViewModel().get('users');

        //this.getView().mask('Registration... Please wait...');      

        //var form = this.getView();

       // var account = Ext.create('App.store.login.Registers');
        //account.sync();
        //account.Email = form.Email;
      
        //console.log(account);

        //account.save({
        //    success: function () {
        //        console.log('The User was updated');
        //    },
        //    scope :true
        //});

       // console.log(record);
    }
   

    
});