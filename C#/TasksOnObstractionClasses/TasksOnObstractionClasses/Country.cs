using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOnObstractionClasses
{
    abstract class Country
    {
        public string CountryName { get; set; }
        public string CountryArea { get; set; }
        public string CountryReligion { get; set; }
        abstract public void PrintInfo();
    }
    class Georgia : Country
    {
        public int TbilisiCitizens {  get; set; }
        override public void PrintInfo()
        {
            Console.WriteLine(TbilisiCitizens);
        }
    }
    class Germany : Country
    {
        public int BerlinCitizens { get; set; }
        override public void PrintInfo()
        {
            Console.WriteLine(BerlinCitizens);
        }
    }
    class Britan : Country
    {
        public int LondonCitizens { get; set; }
        override public void PrintInfo()
        {
            Console.WriteLine(LondonCitizens);
        }
    }
}
