namespace Classes;

public class Customer
{
	private string _logo;
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
	public string Logo{ get => _logo; set => _logo = value;}

    public Customer()
    {
        
    }
    public Customer(string name, string address, string contactNumber="4455667788")
    {
       Name = name;
       Address = address;
       ContactNumber = contactNumber;
    }
    public Customer(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public Customer(string name)
    {
        Name = name;
    }
    
    public void UpdateCustomer(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }
}