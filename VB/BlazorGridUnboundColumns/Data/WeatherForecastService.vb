Namespace BlazorGridUnboundColumns.Data

    Public Class WeatherForecastService

        Public Function GetForecastAsync(ByVal startDate As DateTime) As Task(Of WeatherForecast())
            Dim rng = New Random()
            Return Task.FromResult(Enumerable.Range(1, 5).[Select](Function(index) New WeatherForecast With {.[Date] = startDate.AddDays(index), .TemperatureC = rng.[Next](-20, 30)}).ToArray())
        End Function
    End Class
End Namespace
