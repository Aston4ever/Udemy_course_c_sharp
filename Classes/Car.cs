namespace Classes;

public class Car
{
    private string _brand;
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
                Brand = "default value";
            }
            else
            {
                Brand = value;
            }
        }
    }
    
    public Car(string model, string brand, bool isLuxury = false)
    {
        Model = model;
        Brand = brand;
        IsLuxury = isLuxury;
    }

    public void Drive()
    {
        Console.WriteLine("Driving car");
    }
}