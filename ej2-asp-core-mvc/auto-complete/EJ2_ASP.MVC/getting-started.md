---
layout: post
title: Getting Started with ##Platform_Name## AutoComplete | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Auto Complete control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC AutoComplete Control

This section briefly explains about how to include [ASP.NET MVC AutoComplete](https://www.syncfusion.com/aspnet-mvc-ui-controls/autocomplete) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it.

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion script manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC AutoComplete control

Now, add the Syncfusion ASP.NET MVC AutoComplete control in `~/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<string> data = new List<string>() { "Badminton", "Basketball", "Cricket", "Football", "Golf", "Gymnastics", "Hockey", "Tennis" };
    return View(data);
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC AutoComplete control will be rendered in the default web browser.

![ASP.NET MVC AutoComplete Control](images/autocomplete-component.png)

N> Running the above code will display the basic AutoComplete on the browser.

## Binding data source

After initialization, populate the AutoComplete with data using the [dataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_DataSource) property. Here, an array of string values is passed to the AutoComplete control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<string> data = new List<string>() { "Badminton", "Basketball", "Cricket", "Football", "Golf", "Gymnastics", "Hockey", "Tennis" };
    return View(data);
}
{% endhighlight %}
{% endtabs %}

## Custom values

The AutoComplete allows the user to give input as custom value which is not required to present in predefined set of values. By default, this support is enabled by [allowCustom](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_AllowCustom) property. The custom value will be sent to post back handler when a form is about to be submitted.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/customvalue/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<string> data = new List<string>() { "Badminton", "Basketball", "Cricket", "Football", "Golf", "Gymnastics", "Hockey", "Tennis" };
    return View(data);
}
{% endhighlight %}
{% endtabs %}

## Configure the suggestion list

By default, suggestion list width automatically adjusts according to the AutoComplete input element's width, and the height of the suggestion list has '300px'.

The height and width of the popup list can also be customized using the [popupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_PopupHeight) and [popupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_PopupWidth) property respectively.

In the following sample, suggestion list's width and height are configured.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/suggestionlist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<string> data = new List<string>() { "Badminton", "Basketball", "Cricket", "Football", "Golf", "Gymnastics", "Hockey", "Tennis" };
    return View(data);
}
{% endhighlight %}
{% endtabs %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/AutoComplete/ASP.NET%20MVC%20Razor%20Examples).

## See also

* [How to bind the data](./data-binding/)
