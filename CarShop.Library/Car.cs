using System;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public bool IsAvailable => Convert.ToInt32(Year) > 2010;

        public override string ToString()
        {
            return $"{Model} {Color} {Year}"; 
        }
    }
}
