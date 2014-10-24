using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Computer
{
    private string pcName;
    private IList<Component> pcComponents;

    public string PcName 
    {
        get
        {
            return this.pcName;
        }
        set 
        {
            if (value != null)
            {
                this.pcName = value;
            }
            else 
            {
                throw new AccessViolationException("PC`s name can not ne empty!");
            }
        }
    }
    public IList<Component> PcComponents
    {
        get
        {
            return this.pcComponents;
        }
        set
        {
            if (value.GetType() != null)
            {
                this.pcComponents = value;
            }
            else 
            {
                throw new AccessViolationException("There is NO components in the " + this.pcName);
            }
        }
    }
    public double PcPrice 
    {
        get 
        {
           return this.PcComponents.Sum(component => component.Price);
        }       
    }

    public Computer(string pcName, IList<Component> pcComponents) 
    {
        this.PcName = pcName;
        this.PcComponents = pcComponents;
    }
    
    public string ToString()
    {
        string result = "PC's name: " + this.PcName;
        CultureInfo bg = new CultureInfo("bg-BG");
        foreach (var component in PcComponents)
        {
            result = result + "\nPC's component: " + component.Name + " - price: " + component.Price.ToString("C", bg);
        }
        result = result + "\nTotal PC price: " + this.PcPrice.ToString("C", bg);
        return result;
    }
}