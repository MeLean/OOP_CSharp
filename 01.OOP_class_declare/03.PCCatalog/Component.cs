using System;

class Component
{
    private string name;
    private double price;
    private string details;

    public string Name 
    {
        get 
        {
            return this.name;
        }
        set 
        {
            if (value != null)
            {
                this.name = value;
            }
            else
            {
                throw new AccessViolationException("You have not entered component`s name!"); 
            }
            
        }
    }
    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value > 0)
            {
                this.price = value;
            }
            else
            {
                throw new AccessViolationException("improper price is entered!");
            }

        }
    }
    public string Details 
    {
        get
        {
            return this.details;
        }
        set 
        {
            this.details = value;
        }
    }

    public Component(string name, double price, string details = null)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }
}