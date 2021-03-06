using System;

namespace WebApplication4
{
    public class WeatherForecast
    {
        public int ID { get; set; }
        public DateTime DateTime { get => DateTime.FromBinary(Date); }
        public long Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
