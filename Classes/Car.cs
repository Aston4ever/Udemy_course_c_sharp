namespace Classes;

public class Car
{
    private string _brand;
    private static int NextID = 0;
    private int _id;
    public string Model { get; set; }
    
    public bool IsLuxury { get; set; }
    
    public string Brand
    {
        get
        {
            if (IsLuxury)
            {
                return $"{_brand} Lux version";
            }
            else
            {
                return _brand;
            }
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                _brand = "default value";
            }
            else
            {
                _brand = value;
            }
        }
    }
    public static int NumberOfCars;
    
    public Car(string model, string brand, bool isLuxury = false)
    {
        _id =  NextID++;        
        NumberOfCars++;
        Model = model;
        Brand = brand;
        IsLuxury = isLuxury;
    }

    public void Drive()
    {
        Console.WriteLine("Driving car");
    }

    public static void CarStuff(Car car)
    {
        Console.WriteLine(car._brand);
        
    }
}