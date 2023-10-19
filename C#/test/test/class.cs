
namespace test
{
    class Film
    { 
        public string Name { get; set; }
        public string Ganre { get; set; }
        public string MainActor { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public Film(string name, string ganre, String mainActor, string country, int year)
        {
            this.Name = name;
            this.Ganre = ganre;
            this.MainActor = mainActor;
            this.Country = country;
            this.Year = year;
        }
        public void Info()
        {
            Console.WriteLine(Name + " " + Ganre + " " + MainActor + " " + Country + " " + Year);
        }
    }

}
