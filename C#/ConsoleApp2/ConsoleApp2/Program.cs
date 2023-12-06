class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main()
    {
        List<Person> list = new List<Person> 
        {
            new Person
            {
                Name = "tekle",
                Age = 2,
            },
            new Person
            {
                Name = "tekle",
                Age = 2,
            },
             new Person
            {
                Name = "tekle",
                Age = 2,
            },
        };
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        var numList = new List<int> {2,3,4,45,235423,1,43,5,6,2,3,1,4,68, };
        var notEven = from num in numList
                      where num % 2 == 1
                      select num;
        int firstEven = numList.FirstOrDefault(x => x % 2 == 0);

        // მარცხნიდან პირველი კენტი რიცხვი
        int firstOdd = numList.LastOrDefault(x => x % 2 != 0);
        int[] array = { 2, 3, 134, 7, 23, 4, 73, 5, 2, 34, 7, 2, 34, 234562 };
        Array.Sort(array);
        var moreThenTen = from num in numList
                      where num > 10
                      select num;
        List<Country> countries = new List<Country> {
            new Country
            {
                CountryCode = "tsz234f1JG34"
            }
        };
        List<City> cities = new List<City>
        {
            new City{
                Name = "tbilisi",
                CountryCode = "tsz234f1JG34"
            },
            new City{
                Name = "london",
                CountryCode = "dhoioiosaufg1284"
            }
        };
        var countryCode = from city in cities
                          join Country in countries
                          on city.CountryCode equals Country.CountryCode
                          select city;
    }
}

class City
{
    public string Name { get; set; }
    public string CountryCode { get; set; }
}
class Country
{
    public string CountryCode { get; set; }
}