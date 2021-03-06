﻿Ext.define('App.store.Translation', {
    extend: 'Ext.data.Store',

    alias: 'store.translation',
    storeId: 'translation',

    fields: [
        { name: 'fr' },
        { name: 'en' },
        { name: 'de' }
    ],

    data: {
        fr: {
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
        en : {
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
    },

    autoLoad : true
    
});
