namespace Classes;

class Program
{
    static void Main(string[] args)
    {
         var audi = new Car(model: "Audi", "q7", true); // named parametres
        // audi.Drive();
        Car.CarStuff(audi); //static method
        Customer cus = new Customer("123", "hello0");
        Console.WriteLine(cus.ContactNumber);
        
    }
}