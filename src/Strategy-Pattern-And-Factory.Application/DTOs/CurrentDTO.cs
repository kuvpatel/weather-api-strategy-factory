

namespace Strategy_Pattern_And_Factory.DTOs
{ 
    public class CurrentDTO
    {
        public float TempC { get; set; }

        public float TempF { get; set; }

        public int IsDay { get; set; }

        public ConditionDTO Condition { get; set; }

        public float WindMph { get; set; }

        public float WindKph { get; set; }

        public int WindDegree { get; set; }

        public string WindDir { get; set; }

        public float PressureMb { get; set; }

        public float PressureIn { get; set; }

        public float Humidity { get; set; }

        public float Cloud { get; set; }

        public float FeelsLikeC { get; set; }

        public float FeelsLikeF { get; set; }

        public float WindChillC { get; set; }

        public float WindChillF { get; set; }

        public float HeatIndexC { get; set; }

        public float HeatIndexF { get; set; }

        public float VisKm { get; set; }

        public float VisMiles { get; set; }

        public float Uv { get; set; }

        public float GustMph { get; set; }

        public float GustKph { get; set; }

        public int WillItRain { get; set; }

        public int ChanceOfRain { get; set; }

        public int WillItSnow { get; set; }

        public int ChanceOfSnow { get; set; }

    }
}
