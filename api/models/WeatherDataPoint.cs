using System;

namespace NetCoreRestMySql.models 
{
    public class WeatherDataPoint 
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public float TempC { get; set; }
        public float TempF { get; set; }
        public string Summary { get; set; }
    }
}
