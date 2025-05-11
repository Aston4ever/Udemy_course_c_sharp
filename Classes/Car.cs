namespace Classes;

public class Car
{
    public string Model { get; set; }
    public string Brand
    {
        get => Model;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Brand = "Default";
            }
            else
            {
                Brand = value;
            }
        }
    }
    
    public Car(string model, string brand)
    {
        Model = model;
        Brand = brand;
        
    }
    
    
}