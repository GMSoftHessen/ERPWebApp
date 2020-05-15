/*
 * This file launches the application by asking Ext JS to create
 * and launch() the Application class.
 */
Ext.application({
    extend: 'Packt.Application',

    name: 'Packt',

    requires: [
        // This will automatically load all classes in the Packt namespace
        // so that application classes do not need to require each other.
        'Packt.*'
    ],

   autoCreateViewPort: false
    // The name of the initial view to create.
    //mainView: 'Packt.view.main.Main'
});
