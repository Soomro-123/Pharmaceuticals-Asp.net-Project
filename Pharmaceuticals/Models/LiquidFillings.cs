namespace Pharmaceuticals.Models
{
    public class LiquidFillings
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal AirPressure { get; set; }
        public decimal AirVolume { get; set; }
        public int FillingSpeed { get; set; }
        public decimal FillingRange { get; set; }
    }

}
