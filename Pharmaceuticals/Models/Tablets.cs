namespace Pharmaceuticals.Models
{
    public class Tablets
    {
        public int Id { get; set; }
        public string ModelNumber { get; set; }
        public string Dies { get; set; }
        public decimal MaxPressure { get; set; }
        public decimal MaxDiameter { get; set; }
        public decimal MaxDepth { get; set; }
        public int ProductionCapacity { get; set; }
        public string MachineSize { get; set; }
        public decimal NetWeight { get; set; }
    }

}
