
Ext.define('App.view.system.currency.CurrencyView', {
    extend: 'Ext.form.Panel',
    xtype: 'sys-currency',
    requires: [
        'Ext.grid.*',
        'Ext.form.*',
        'Ext.layout.container.Column',
        'KitchenSink.model.Company',
        'App.view.system.currency.CurrencyViewController',
        'App.view.system.currency.CurrencyViewModel'
    ],

    controller: 'system-currency-currencyview',
    viewModel: {
        type: 'system-currency-currencyview'
    },

    title: 'Company data',
    width: 880,
    frame: true,
    bodyPadding: 5,
    layout: 'column',
    signTpl: '<span style="' +
        'color:{value:sign(\'"#cf4c35"\',\'"#73b51e"\')}"' +
        '>{text}</span>',

    viewModel: {
        data: {
            theCompany: null
        }
    },

    fieldDefaults: {
        labelAlign: "left",
        labelWidth: 90,
        anchor: '100%',
        msgTarget: 'side'
    },

    items: [{
        xtype: 'gridpanel',

        height: 400,
        columnWidth: 0.65,

        bind: {
            selection: '{theCompany}'
        },
        store: {
            type: 'companies'
        },

        columns: [{
            text: 'Company',
            dataIndex: 'name',

            flex: 1,
            sortable: true
        }, {
            text: 'Price',
            dataIndex: 'price',

            width: 75,
            sortable: true
        }, {
            text: 'Change',
            dataIndex: 'priceChange',

            width: 80,
            sortable: true,
            renderer: 'renderChange'
        }, {
            text: '% Change',
            dataIndex: 'priceChangePct',

            width: 100,
            sortable: true,
            renderer: 'renderPercent'
        }, {
            text: 'Last Updated',
            dataIndex: 'priceLastChange',

            width: 115,
            sortable: true,
            formatter: 'date("m/d/Y")'
        }, {
            text: 'Rating',
            dataIndex: 'rating',

            width: 60,
            sortable: true,
            formatter: 'pick("A","B","C")'
        }]
    }, {
        xtype: 'fieldset',
        title: 'Company details',

        columnWidth: 0.35,
        margin: '0 0 0 10',
        layout: 'anchor',
        defaultType: 'textfield',

        items: [{
            fieldLabel: 'Name',
            bind: '{theCompany.name}'
        }, {
            fieldLabel: 'Price',
            bind: '{theCompany.price}'
        }, {
            fieldLabel: '% Change',
            bind: '{theCompany.priceChangePct}'
        }, {
            xtype: 'radiogroup',
            fieldLabel: 'Rating',
            bind: '{theCompany.rating}',

            // Maps the value of this radiogroup to the child radio with matching
            // inputValue.
            simpleValue: true,
            columns: 3,

            items: [{
                boxLabel: 'A',
                inputValue: 0
            }, {
                boxLabel: 'B',
                inputValue: 1
            }, {
                boxLabel: 'C',
                inputValue: 2
            }]
        }, {
            labelAlign: 'top',
            xtype: 'datefield',
            fieldLabel: 'Last Updated (Not editable)',
            labelSeparator: '',
            bind: '{theCompany.priceLastChange}',

            // This field is only set when the price changes
            // The Model rejects set changes.
            readOnly: true
        }]
    }]



    //html: 'Währungen'
});
