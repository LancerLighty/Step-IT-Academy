
namespace TasksOnClass
{
    class Country
    {
        public string Name { get; set; }
        public string TheretoryOnMap { get; set; }
        public int CityCount { get; set; }
        public string TheCapital { get; set; }
        public Country(string name, string theretoryOnMap, int cityCount, string theCapital)
        {
            this.Name = name;
            this.TheretoryOnMap = theretoryOnMap;
            this.CityCount = cityCount;
            this.TheCapital = theCapital;
        }
        public void CountryInfo()
        {
            Console.WriteLine($"country name: {Name}");
            Console.WriteLine($"Theretory On Map: {TheretoryOnMap}");
            Console.WriteLine($"City Count: {CityCount}");
            Console.WriteLine($"The Capital city: {TheCapital}");
        }
    }
}
