# Blazor Grid - Greate unbound columns

The Grid allows you to add [unbound columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundType) whose values are not stored in the assigned data collection.

![Grid with unbound columns](/grid-with-unbound-columns.png)

You can calculate column values in two ways:

* Specify the [UnboundExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundExpression) that calculates unbound column values based on other column values. In this example, the **TemperatureF** column uses this property to fill its cells
* Handle the [UnboundColumnData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.UnboundColumnData) event to supply unique column values based on custom logic. In this example, the **Summary** column uses this event to fill its cells.

Then, add implementation details (steps, code snippets, and other technical information in a free form), or add a link to an existing document with implementation details. 

## Files to Review

[Index.razor](/CS/BlazorGridUnboundColumns/Pages/Index.razor)

## Documentation

[Create an unbound column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn#create-an-unbound-column)

## More Examples

[Create a ComboBox (Foreign Key) Column](https://github.com/DevExpress-Examples/blazor-grid-foreignkey-column)
