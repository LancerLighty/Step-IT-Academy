
using System.Xml.Linq;

namespace TasksOnClass { 
    class Car
    {
        public string CarBrand { get; set; }
        public string FullCarName { get; set; }
        public string Class { get; set; }
        public string Colour { get; set; }
        public int CarYear { get; set; }
        public Car(string carBrand, string fullCarName, string Class, string colour, int carYear)
        {
            this.CarBrand = carBrand;
            this.FullCarName = fullCarName;
            this.Class = Class;
            this.Colour = colour;
            this.CarYear = carYear;
        }
        public void CarInfo()
        {
            Console.WriteLine($"Car Brand: {CarBrand}");
            Console.WriteLine($"Full Car Name: {FullCarName}");
            Console.WriteLine($"Car Description: {Class}");
            Console.WriteLine($"Car Colour: {Colour}");
            Console.WriteLine($"Car Year: {CarYear}");
        }
    }
}
