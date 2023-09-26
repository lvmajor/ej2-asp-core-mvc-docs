---
layout: post
title: Data Binding in ##Platform_Name## Schedule Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Schedule component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data-binding

The Scheduler uses `dataManager`, which supports both RESTful JSON data services binding and local JavaScript object array binding. The [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Schedule.ScheduleEventSettings~DataSource.html) property can be assigned either with the instance of `dataManager` or JavaScript object array collection. It supports two kinds of data binding method:

* Local data
* Remote data

## Binding local data

To bind local JSON data to the Scheduler, you can simply assign a JavaScript object array to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Schedule.ScheduleEventSettings~DataSource.html) option of the scheduler within the `eventSettings` property. The local data source can also be provided as an instance of the `dataManager`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/local-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/local-data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/local-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/local-data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Custom binding

It is possible to create your own custom adaptor by extending the built-in available adaptors. The following example demonstrates the custom adaptor usage and how to add a custom field `EventID` for the appointments by overriding the built-in response processing using the `processResponse` method of the `ODataV4Adaptor`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/custom-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/custom-adaptor/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/custom-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/custom-adaptor/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> By default, `dataManager` uses `JsonAdaptor` for local data-binding.

You can also bind different field names to the default event fields as well as include additional custom fields to the event object collection which can be referred [here](./appointments/#binding-different-field-names).

## Remote data

Any kind of remote data services can be bound to the Scheduler. To do so, create an instance of `dataManager` and provide the service URL to the `Url` option of `dataManager` and then assign it to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Schedule.ScheduleEventSettings~DataSource.html) property within `e-schedule-eventsettings`.

### Binding data with OData services

[OData](https://www.odata.org/documentation/odata-version-3-0/) ((Open Data Protocol)) is a widely used protocol for creating and consuming RESTful APIs over various transport protocols such as HTTP, HTTPS, and others. It offers a standardized way for creating, retrieving, updating, and deleting data across various platforms and devices. OData provides a uniform way for interacting with data, which simplifies the task of developing and consuming RESTful APIs.

You can retrieve data from OData service using the `dataManager`. Refer to the following code example for remote Data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/Odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/Odata/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/Odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/Odata/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Binding data with OData V4 services

[ODataV4](https://www.odata.org/documentation/) is a standardized protocol for creating and consuming data. Refer to the following code example to retrieve the data from ODataV4 service using the dataManager. To connect with ODataV4 service end points, it is necessary to make use of `ODataV4Adaptor` within `dataManager`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/Odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/Odata/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/Odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/Odata/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Filter events using the in-built query

To enable server-side filtering operations based on predetermined conditions, the [`includeFiltersInQuery`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.ScheduleEventSettings.html#Syncfusion_EJ2_Schedule_ScheduleEventSettings_IncludeFiltersInQuery) API can be set to true, this allows the filter query to be constructed using the start date, end date, and recurrence rule which in turn enables the request to be filtered accordingly.

This method greatly improves the component's performance by reducing the data that needs to be transferred to the client side. As a result, the component's efficiency and responsiveness are significantly enhanced, resulting in a better user experience. However, it is important to consider the possibility of longer query strings, which may cause issues with the maximum URL length or server limitations on query string length.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/OdataV4-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/OdataV4-filter/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/OdataV4-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/OdataV4-filter/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
  
The following image represents how the parameters are passed using ODataV4 filter.

![OData V4 filter](images/odata-v4-filter.png)

### Web API adaptor

You can bind Web API data to the scheduler using [`WebApiAdaptor`]. The following sample code demonstrates the way of binding remote services to the Scheduler component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/web-api/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/web-api/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/web-api/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/web-api/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Url adaptor

You can use the [`UrlAdaptor`] when binding data source for remote data. During the initial load of Scheduler, data are fetched from remote data and bound to the Scheduler using the [Url] property of **DataManager**.

CRUD operations in the Scheduler can be mapped to server-side controller actions by using the properties [`InsertUrl`], [`RemoveUrl`], [`UpdateUrl`], and [`CrudUrl`].

* `InsertUrl` – You can perform a single insertion operation on the server-side.
* `UpdateUrl` – You can update single data on the server-side.
* `RemoveUrl` – You can remove single data on the server-side.
* `CrudUrl` – You can perform bulk data operation on the server-side.

The following sample code demonstrates binding data to the Scheduler component through the SfDataManager using UrlAdaptor.

```sh
@using Syncfusion.EJ2

@{
    var dataManager = new DataManager() {
        Url = "Home/GetData",
        Adaptor = "UrlAdaptor",
        CrudUrl = "Home/UpdateData",
        CrossDomain = true
    };
}

<ejs-schedule id="schedule" width="100%" height="550" selectedDate="new DateTime(2017, 6, 5)">
    <e-schedule-eventsettings dataSource="dataManager">
    </e-schedule-eventsettings>
</ejs-schedule>

```

The server-side controller code to handle the CRUD operations is as follows.

```sh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScheduleSample.Models;

namespace ScheduleSample.Controllers
{
    public class HomeController : Controller
    {
        ScheduleDataDataContext db = new ScheduleDataDataContext();
        public ActionResult Index()
        {
            return View();
        }  
        public ActionResult LoadData()  // Here we get the Start and End Date and based on that can filter the data and return to Scheduler
        {
            var data = db.ScheduleEventDatas.ToList();
            return Json(data);
        }
        [HttpPost]
        public ActionResult UpdateData([FromBody] EditParams param)
        {
            if (param.action == "insert" || (param.action == "batch" && param.added != null)) // this block of code will execute while inserting the appointments
            {
                var value = (param.action == "insert") ? param.value : param.added[0];
                int intMax = db.ScheduleEventDatas.ToList().Count > 0 ? db.ScheduleEventDatas.ToList().Max(p => p.Id) : 1;
                DateTime startTime = Convert.ToDateTime(value.StartTime);
                DateTime endTime = Convert.ToDateTime(value.EndTime);
                ScheduleEventData appointment = new ScheduleEventData()
                {
                    Id = intMax + 1,
                    StartTime = startTime,
                    EndTime = endTime,
                    Subject = value.Subject,
                    IsAllDay = value.IsAllDay,
                    StartTimezone = value.StartTimezone,
                    EndTimezone = value.EndTimezone,
                    RecurrenceRule = value.RecurrenceRule,
                    RecurrenceID = value.RecurrenceID,
                    RecurrenceException = value.RecurrenceException
                };
                db.ScheduleEventDatas.InsertOnSubmit(appointment);
                db.SubmitChanges();
            }
            if (param.action == "update" || (param.action == "batch" && param.changed != null)) // this block of code will execute while updating the appointment
            {
                var value = (param.action == "update") ? param.value : param.changed[0];
                var filterData = db.ScheduleEventDatas.Where(c => c.Id == Convert.ToInt32(value.Id));
                if (filterData.Count() > 0)
                {
                    DateTime startTime = Convert.ToDateTime(value.StartTime);
                    DateTime endTime = Convert.ToDateTime(value.EndTime);
                    ScheduleEventData appointment = db.ScheduleEventDatas.Single(A => A.Id == Convert.ToInt32(value.Id));
                    appointment.StartTime = startTime;
                    appointment.EndTime = endTime;
                    appointment.StartTimezone = value.StartTimezone;
                    appointment.EndTimezone = value.EndTimezone;
                    appointment.Subject = value.Subject;
                    appointment.IsAllDay = value.IsAllDay;
                    appointment.RecurrenceRule = value.RecurrenceRule;
                    appointment.RecurrenceID = value.RecurrenceID;
                    appointment.RecurrenceException = value.RecurrenceException;
                }
                db.SubmitChanges();
            }
            if (param.action == "remove" || (param.action == "batch" && param.deleted != null)) // this block of code will execute while removing the appointment
            {
                if (param.action == "remove")
                {
                    int key = Convert.ToInt32(param.key);
                    ScheduleEventData appointment = db.ScheduleEventDatas.Where(c => c.Id == key).FirstOrDefault();
                    if (appointment != null) db.ScheduleEventDatas.DeleteOnSubmit(appointment);
                }
                else
                {
                    foreach (var apps in param.deleted)
                    {
                        ScheduleEventData appointment = db.ScheduleEventDatas.Where(c => c.Id == apps.Id).FirstOrDefault();
                        if (appointment != null) db.ScheduleEventDatas.DeleteOnSubmit(appointment);
                    }
                }
                db.SubmitChanges();
            }
            var data = db.ScheduleEventDatas.ToList();
            return Json(data);
        }

        public class EditParams
        {
            public string key { get; set; }
            public string action { get; set; }
            public List<ScheduleEventData> added { get; set; }
            public List<ScheduleEventData> changed { get; set; }
            public List<ScheduleEventData> deleted { get; set; }
            public ScheduleEventData value { get; set; }
        }
    }
}
```

N> You can find the working sample [here](https://github.com/SyncfusionExamples/aspnetcore-scheduler-crud-actions-with-editor-template).

### Passing additional parameters to the server

To send an additional custom parameter to the server-side post, you need to make use of the `addParams` method of `query`. Now, assign this `query` object with additional parameters to the [`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Schedule.ScheduleEventSettings~Query.html)property of Scheduler.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/additional-parameter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/additional-parameter/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/additional-parameter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/additional-parameter/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> The parameters added using the `query` property will be sent along with the data request sent to the server on every scheduler actions.

### Handling failure actions

During server interaction from the Scheduler, sometimes server-side exceptions might occur. These error messages or exception details can be acquired in client-side using the [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Schedule.Schedule~ActionFailure.html) event.

The argument passed to the [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Schedule.Schedule~ActionFailure.html) event contains the error details returned from the server.

The following sample code demonstrates notifying user when server-side exception has occurred,

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/failure-actions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/failure-actions/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/failure-actions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/failure-actions/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> The argument passed to the `actionFailure` event contains the error details returned from the server.

## Loading data via AJAX post

You can bind the event data through external ajax request and assign it to the `dataSource` property of Scheduler. In the following code example, we have retrieved the data from server with the help of ajax request and assigned the resultant data to the `dataSource` property of Scheduler within the `onSuccess` event of Ajax.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/ajax/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/ajax/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/ajax/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/ajax/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Definition for the controller method `GetData` can be referred [here](#scheduler-crud-actions).

## Performing CRUD using Entity Framework

You need to follow the below steps to consume data from the Entity Framework in our Scheduler component.

### Creating OData Controller

A OData Controller has to be created which allows Scheduler directly to consume data from the Entity Framework. The following code example shows how to perform CRUD operations using Entity Framework.

```sh
using ej2_web_api_crud.Data;
using ej2_web_api_crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Web;

namespace ej2_web_api_crud.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventsContext dbContext;
        public EventsController(EventsContext dbContext)
        {
            this.dbContext = dbContext;
            if (this.dbContext.Events.Count() == 0)
            {
                foreach (var b in DataSource.GetEvents())
                {
                    dbContext.Events.Add(b);
                }
                dbContext.SaveChanges();
            }
        }

        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(dbContext.Events);
        }

        [HttpPost]
        public async Task Post([FromBody] Event events)
        {
            dbContext.Events.Add(events);
            await dbContext.SaveChangesAsync();
        }

        [HttpPut]
        public async Task Put([FromODataUri] int key, [FromBody] Event events)
        {
            var entity = await dbContext.Events.FindAsync(events.Id);
            if(entity != null)
            {
                dbContext.Entry(entity).CurrentValues.SetValues(events);
                await dbContext.SaveChangesAsync();
            }
        }

        [HttpPatch]
        public async Task Patch([FromODataUri] int key, [FromBody] Event events)
        {
            var entity = await dbContext.Events.FindAsync(key);
            if(entity != null)
            {
                dbContext.Entry(entity).CurrentValues.SetValues(events);
                await dbContext.SaveChangesAsync();
            }
        }
        [HttpDelete]
        public async Task Delete([FromODataUri] int key)
        {
            var app = dbContext.Events.Find(key);
            if(app != null)
            {
                dbContext.Events.Remove(app);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
```

### Configure Scheduler component using ODataV4Adaptor

Now, the Scheduler can be configured using the `DataManager` to interact with the created OData service and consume the data appropriately. To interact with OData, use `ODataV4Adaptor`.

```sh
@using Syncfusion.EJ2
@using Syncfusion.EJ2.Schedule

@{
    var dataManager = new DataManager() { 
        Url = "https://localhost:44360/api/",
        Adaptor = "ODataV4Adaptor",
        CrossDomain = true 
    };
}

<ejs-schedule id="schedule" width="100%" height="550" selectedDate="new DateTime(2020, 9, 20)" readonly="true">
    <e-schedule-eventsettings dataSource="dataManager" query="new ej.data.Query().from('Events')">
    </e-schedule-eventsettings>
</ejs-schedule>

```

## Configuring Scheduler with Google API service

We have assigned our custom created Google Calendar url to the DataManager and assigned the same to the Scheduler `dataSource`. Since the events data retrieved from the Google Calendar will be in its own object format, therefore it needs to be resolved manually within the Scheduler’s `dataBinding` event. Within this event, the event fields needs to be mapped properly and then assigned to the result.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/google-calendar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/google-calendar/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/data-binding/google-calendar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/data-binding/google-calendar/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


N> You can refer to our [ASP.NET Core Scheduler](https://www.syncfusion.com/aspnet-core-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Scheduler example](https://ej2.syncfusion.com/aspnetcore/Schedule/Overview#/material) to knows how to present and manipulate data.
