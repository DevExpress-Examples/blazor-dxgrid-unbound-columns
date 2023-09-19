namespace BlazorGridUnboundColumns.Data {
    public class EditableWeatherForecast : WeatherForecast {
        public double TemperatureF {
            get => (base.TemperatureC / 0.5556) + 32;
            set => base.TemperatureC = (value - 32) * 0.5556;
        }
    }
}
