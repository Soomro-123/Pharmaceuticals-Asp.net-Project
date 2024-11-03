namespace Pharmaceuticals.Models
{
    public class Capsules
    {
     

            public int Id { get; set; }
            public string CapsuleName { get; set; }
            public int Output { get; set; } // Capsules per hour
            public decimal CapsuleSize { get; set; } // in mm
            public string MachineDimension { get; set; } // written as x-axis x y-axiz x z-axis 
            public decimal ShippingWeight { get; set; } // in kg

        
    }


}
