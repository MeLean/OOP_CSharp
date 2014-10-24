using System;
using System.Collections.Generic;
/* Define a class Laptop that holds the following information about a laptop device: model,
 * manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
•	The model and price are mandatory. All other values are optional.
•	Define two separate classes: a class Laptop holding an instance of class Battery.
•	Define several constructors that take different sets of arguments 
 * (full laptop + battery information or only part of it). Use proper variable types.
•	Add a method in the Laptop class that displays information about the given instance
o	Tip: override the ToString() method
•	Put validation in all property setters and constructors. String values cannot be empty, 
 * and numeric data cannot be negative. Throw exceptions when improper data is entered.*/
class Laptop
{
    private string model;
    private double price;
    private string manufacturer;
    private string processor;
    private int? ram;
    private string grCard;
    private int? hardDisk;
    private string screen;
    private string battery;
    private double? batteryLife;    

    public string Model
    {
        get 
        {
            return this.model;
        }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The model's value can not be empty!");
            }
            this.model = value;
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
            if (value >= 0)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("The price's value must be positive number!");
            }
        }
    }
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The manufacturer's value can not be empty!");
            }
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The processor's value can not be empty!");
            }
            this.processor = value;
        }
    }
    public int? RAM 
    {
        get
        {
            return this.ram;
        }
        set 
        {
            if (value > 0 || value == null)
            {
                this.ram = value;
            }
            else 
            {
                throw new ArgumentException("RAM's value must be a number, greater then 0!");
            }
        }
    }
    public string GrCard
    {
        get
        {
            return this.grCard;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The graphics card's value can not be empty!");
            }
            this.grCard = value;
        }
    }
    public int? HardDisk
    {
        get
        {
            return this.hardDisk;
        }
        set
        {
            if (value > 0 || value == null)
            {
                this.hardDisk = value;
            }
            else
            {
                throw new ArgumentException("The hard disk drive's value must be a number, greater then 0!");
            }
        }
    }
    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The screen's value can not be empty!");
            }
            this.screen = value;
        }
    }
    public string Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The Battery type's value can not be empty!");
            }
            this.battery = value;
        }
    }
    public double? BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if (value > 0 || value == null)
            {
                this.batteryLife = value;
            }
            else
            {
                throw new ArgumentException("The baterry life's value must be a floting point number, greater then 0!");
            }
        }
    }

    public Laptop(string model, double price, string manufacturer, string processor, int? ram, string grCard, int? hardDisk, string screen, string battery, double? batteryLife) 
    {
        this.Model = model;
        this.Price = price;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GrCard = grCard;
        this.HardDisk = hardDisk;
        this.Screen = screen;
        this.Battery = battery;
        this.BatteryLife = batteryLife;        
    }
    public Laptop(string model, double price, string manufacturer, string processor, int? ram, string grCard, int? hardDisk, string screen, string battery)
        : this(model, price, manufacturer, processor, ram, grCard, hardDisk, screen, battery, null) 
    {
    }
    public Laptop(string model, double price, string manufacturer, string processor, int? ram, string grCard, int? hardDisk, string screen)
        : this(model, price, manufacturer, processor, ram, grCard, hardDisk, screen, null, null)
    {
    }
    public Laptop(string model, double price, string manufacturer, string processor, int? ram, string grCard, int? hardDisk)
        : this(model, price, manufacturer, processor, ram, grCard, hardDisk, null, null, null)
    {
    }
    public Laptop(string model, double price, string manufacturer, string processor, int? ram, string grCard)
        : this(model, price, manufacturer, processor, ram, grCard, null, null, null, null)
    {
    }
    public Laptop(string model, double price, string manufacturer, string processor, int? ram)
        : this(model, price, manufacturer, processor, ram, null, null, null, null, null)
    {
    }
    public Laptop(string model, double price, string manufacturer, string processor)
        : this(model, price, manufacturer, processor, null, null, null, null, null, null)
    {
    }
    public Laptop(string model, double price, string manufacturer)
        : this(model, price, manufacturer, null, null, null, null, null, null, null)
    {
    }
    public Laptop(string model, double price)
        : this(model, price, null, null, null, null, null, null, null, null)
    {
    }

    public override string ToString()
    {
        string modelRow = "model " + this.Model + "\n";
        string priceRow = string.Format("price {0:F2} lv.", this.Price);
        string manifRow = null;
        string processorRow = null;
        string ramRow = null;
        string grCardRow = null;
        string hardDiskRow = null;
        string screenRow = null;
        string batteryRow = null;
        string batteryLifeRow = null;

        if(this.Manufacturer != null)
        {
            manifRow = "manufacturer " + this.Manufacturer + "\n";
        }
        if (this.Processor != null)
        {
            processorRow = "processor " + this.Processor + "\n";
        }
        if (this.RAM != null)
        {
            ramRow = "RAM " + this.RAM + " GB\n";
        }
        if (this.GrCard != null)
        {
            grCardRow = "graphics card " + this.GrCard + "\n";
        }
        if (this.HardDisk != null)
        {
            hardDiskRow = "HDD " + this.HardDisk + "GB SSD\n";
        }
        if (this.Screen != null)
        {
            screenRow = "screen " + this.Screen + "\n";
        }
        if (this.Battery != null)
        {
            batteryRow = "battery " + this.Battery + "\n";
        }
        if (this.BatteryLife != null)
        {
            batteryRow = "battery " + this.BatteryLife + " hours\n";
        }
       
        string result = modelRow + manifRow + processorRow + ramRow + grCardRow + hardDiskRow + screenRow + batteryRow + batteryLifeRow + priceRow;
        return result;
    }
}
