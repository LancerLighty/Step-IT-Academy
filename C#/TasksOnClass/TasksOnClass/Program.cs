using TasksOnClass;

class Prgoram
{
    static void Main()
    {
        Country country = new Country("Georgia","Caucasus",123,"tbilisi");
        country.CountryInfo();
        Car car = new Car("Audi", "Audi SQ5", "Diesel/Electric","Black",2024);
        car.CarInfo();
    }
}