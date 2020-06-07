language = {
    fr: {
        "menu": "menu",
        "login": "Login_Fr",
        "user": "User Fr",
        "password": "Password Fr",
        "cancel": "Cancel Fr",
        "submit": "Submit Fr",
        "logout": "Logout",
        "capsLockTitle": "Caps Lock is On",
        "capsLockMsg1": "Having Caps Lock on may cause you to ",
        "capsLockMsg2": "enter your password incorrectly.",
        "capsLockMsg3": "You should press Caps Lock to turn it ",
        "capsLockMsg4": "off before entering your password."
    },
    en: {
        "menu": "menu",
        "login": "Login",
        "user": "User",
        "password": "Password",
        "cancel": "Cancel",
        "submit": "Submit",
        "logout": "Logout",
        "capsLockTitle": "Caps Lock is On",
        "capsLockMsg1": "Having Caps Lock on may cause you to ",
        "capsLockMsg2": "enter your password incorrectly.",
        "capsLockMsg3": "You should press Caps Lock to turn it ",
        "capsLockMsg4": "off before entering your password."
    },
    de: {
        "menu": "menu",
        "login": "Anmelden",
        "user": "Benutzer",
        "password": "Passwort",
        "cancel": "Abbrechen",
        "submit": "Bestätigen",
        "logout": "Abmelden",
        "capsLockTitle": "Die Feststelltaste ist aktiviert",
        "capsLockMsg1": "Wenn Sie die Feststelltaste aktiviert haben, kann dies dazu führen ",
        "capsLockMsg2": "Geben Sie Ihr Passwort falsch ein.",
        "capsLockMsg3": "Sie sollten die Feststelltaste drücken, um sie zu drehen ",
        "capsLockMsg4": "aus, bevor Sie Ihr Passwort eingeben."
    }
};
var storeTest = Ext.create('Ext.data.Store', {
    autoLoad: false,
    fields: [
        { name: 'en', type: 'string' },
        { name: 'de', type: 'string' },
        { name: 'fr', type: 'string' }
    ],

    proxy: {
        type: 'ajax',
        url: 'http://localhost:1841/resources/locale/Users.json',
        reader: {
            type: 'json'
            //,
            //rootProperty: 'en'
        }
    }
});

getTranslations = function () {

    var lang = localStorage ? (localStorage.getItem('user-lang') || 'en') : 'en';
    var test = storeTest.isLoaded();
  
    if (storeTest.isLoaded() === true) {
        storeTest.proxy.reader.setRootProperty(lang);
        storeTest.load();

        return storeTest.data.items[0].data;
    }
  
    return language[lang];   
};
translations = getTranslations();
