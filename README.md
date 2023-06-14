<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/616967538/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1154960)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Blazor Grid - Create unbound columns

The Grid allows you to add [unbound columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundType) whose values are not stored in the assigned data collection.

![Grid with unbound columns](/grid-with-unbound-columns.png)

You can calculate column values in two ways:

* Specify the [UnboundExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundExpression) property to calculate unbound column values based on other column values. In this example, the **TemperatureF** column uses this property to fill its cells.
* Handle the [UnboundColumnData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.UnboundColumnData) event to supply unique column values based on custom logic. In this example, the **Summary** column uses this event to fill its cells.

## Files to Review

[Index.razor](/CS/BlazorGridUnboundColumns/Pages/Index.razor)

## Documentation

[Create an unbound column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn#create-an-unbound-column)

## More Examples

[Create a ComboBox (Foreign Key) Column](https://github.com/DevExpress-Examples/blazor-grid-foreignkey-column)
