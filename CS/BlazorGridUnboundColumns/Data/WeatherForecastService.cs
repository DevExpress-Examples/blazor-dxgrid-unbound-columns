namespace BlazorGridUnboundColumns.Data {
    public class WeatherForecastService {
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate) {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 30),
            }).ToArray());
        }
    }
}