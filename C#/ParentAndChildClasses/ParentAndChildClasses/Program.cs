class Program
{
    static void Main(string[] args)
    {

    }
}
class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Size { get; set; }
    public Animal(string name, string colour, double size) { 
        Name = name; 
        Colour = colour; 
        Size = size;
    }
}
class Reptile : Animal // shvilobili klasi
{
    public int FeetCount { get; set; }
    public Reptile(string name, string colour, double size, int feetCount ) : base (name,colour,size)
    {
        FeetCount = feetCount;
    }


}