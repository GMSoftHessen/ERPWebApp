

Ext.application({
    extend: 'App.Application',

    name: 'App',

    requires: [
        // This will automatically load all classes in the App namespace
        // so that application classes do not need to require each other.
        'App.*'
    ],
   
    // The name of the initial view to create.
  //  mainView: 'App.view.login.Login' //'App.view.main.Main'
});
