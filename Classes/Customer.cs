﻿namespace Classes;

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }

    public Customer()
    {
        
    }
    public Customer(string name, string address, string contactNumber)
    {
       Name = name;
       Address = address;
       ContactNumber = contactNumber;
    }

    public Customer(string name)
    {
        Name = name;
    }
}