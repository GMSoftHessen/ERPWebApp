﻿Ext.define('EddkaApp.view.sales.customer.Calender', {
    extend: 'Ext.Panel',
    xtype: 'app-calendar',

    requires: [
		 'Ext.calendar.panel.Panel'
    ],

    layout: 'fit',

    items: [{
    	 xtype: 'calendar'
    	//views: {
    	//	day: {
    	//		startTime: 6,
    	//		endTime: 22
    	//	}
           /*,
    		workweek: {
    			xtype: 'calendar-week',
    			titleTpl: '{start:date("j M")} - {end:date("j M")}',
    			label: 'Work Week',
    			weight: 15,
    			dayHeaderFormat: 'D d',
    			firstDayOfWeek: 1,
    			visibleDays: 5
    		}*/
    	//},
    	//timezoneOffset: 0
  /*,
    	store: {
    		autoLoad: true,
    		proxy: {
    			type: 'ajax',
    			url: '/KitchenSink/CalendarFull'
    		}
    	}*/
    }]

});