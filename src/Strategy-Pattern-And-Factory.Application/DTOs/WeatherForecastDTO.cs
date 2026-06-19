namespace Strategy_Pattern_And_Factory.DTOs
{
    public class WeatherForecastDTO
    {
        public LocationDTO Location { get; set; }

        public CurrentDTO Current { get; set; }
        
        public List<ForecastDayDTO> Forecast { get; set; }
    }

 
    public class ForecastDayDTO
    {
        public string Date { get; set; }
        public float MaxTempC { get; set; }
        public float MaxTempF { get; set; }
        public float MinTempC { get; set; }
        public float MinTempF { get; set; }
        public float AvgTempC { get; set; }
        public float AvgTempF { get; set; }
        public float MaxwindMph { get; set; }
        public float MaxwindKph { get; set; }
        public float TotalPrecipMm { get; set; }
        public float TotalPrecipIn { get; set; }
        public float TotalSnowCm{ get; set; }
        public float AvgvisKm { get; set; }
        public float AvgvisMiles { get; set; }
        public float Avghumidity { get; set; }
        public int DailyWillItRain { get; set; }
        public float DailyChanceOfRain { get; set; }
        public int DailyWillItSnow { get; set; }
        public float DailyChanceOfSnow { get; set; }
        public ConditionDTO Condition { get; set; }
        public float Uv { get; set; }
    }

    public class ConditionDTO
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public int Code { get; set; }
    }
}