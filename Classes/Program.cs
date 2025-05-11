namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        var audi = new Car("Audi", "q7");
        Console.WriteLine(audi.Model);
    }
}