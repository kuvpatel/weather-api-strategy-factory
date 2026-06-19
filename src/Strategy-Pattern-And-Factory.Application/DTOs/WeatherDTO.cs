
namespace Strategy_Pattern_And_Factory.DTOs
{
    public class WeatherDTOX
    {
        public string Location { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public float TempCelcius { get; set; }
        public float TempFarenheit { get; set; }
        public string Condition { get; set; }
        public float Humidity { get; set; }
        public float Cloud { get; set; }
        public string Localtime { get; set; }

    }



    public class WeatherDTO
    {
        public LocationDTO Location { get; set; }
        public CurrentDTO Current { get; set; }
    }

}