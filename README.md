<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/616967538/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1154960)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor Grid - Create and edit unbound columns

The Grid allows you to add [unbound columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundType) whose values are not stored in the assigned data collection.

![Grid with unbound columns](/grid-with-unbound-columns.png)

You can calculate column values in two ways:

* Specify the [UnboundExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundExpression) property to calculate unbound column values based on other column values. In this example, the [TemperatureF](/CS/BlazorGridUnboundColumns/Pages/Index.razor#L15) column uses this property to fill its cells.
* Handle the [UnboundColumnData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.UnboundColumnData) event to supply unique column values based on custom logic. In this example, the [Summary](/CS/BlazorGridUnboundColumns/Pages/Index.razor#L19) column uses this event to fill its cells.

You can also implement an editable unbound column. Follow the steps below:

* Create a [derived class](/CS/BlazorGridUnboundColumns/Data/EditableWeatherForecast.cs) from the class that implements your business object.
* In the derived class, override properties that are used to calculate unbound column values. These overrides should map cell values and the base property.
* Specify the [EditFormTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditFormTemplate).
* Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeEditModel) event to use derived class for editing.
* Handle the [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditModelSaving) event to apply changes to you data source.

## Files to Review

[Index.razor](/CS/BlazorGridUnboundColumns/Pages/Index.razor)

## Documentation

[Create an unbound column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn#create-an-unbound-column)

## More Examples

[Create a ComboBox (Foreign Key) Column](https://github.com/DevExpress-Examples/blazor-grid-foreignkey-column)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-dxgrid-unbound-columns&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-dxgrid-unbound-columns&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
