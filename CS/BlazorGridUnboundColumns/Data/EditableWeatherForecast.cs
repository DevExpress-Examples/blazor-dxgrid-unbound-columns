namespace BlazorGridUnboundColumns.Data {
    public class EditableWeatherForecast : WeatherForecast {
        public float TemperatureF {
            get => (float)((base.TemperatureC / 0.5556) + 32);
            set => base.TemperatureC = (float)((value - 32) * 0.5556);
        }
    }
}
