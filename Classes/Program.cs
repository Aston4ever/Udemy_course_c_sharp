namespace Classes;

class Program
{
    static void Main(string[] args)
    {
         var audi = new Car(model: "Audi", "q7", true); // named parametres
        // audi.Drive();
        Car.CarStuff(); //static method
        Customer cus = new Customer();
        
    }
}