using System;
using System.Collections.Generic;
using System.Linq;

class TestComputer
{
    static void Main()
    {

        Component mb1 = new Component("motherboard", 55);
        Component mb2 = new Component("motherboard", 50);
        Component mb3 = new Component("motherboard", 44);
        Component prIntel = new Component("processor", 250, "intel");
        Component prAMD = new Component("processor", 190, "AMD");
        Component grCard2GB = new Component("graphics card", 480, "2GB");
        Component grCard1GB = new Component("graphics card", 320, "1GB");
        Component grCard512MB = new Component("graphics card", 180, "512MB");
        Component ram8GB = new Component("RAM", 280, "8GB");
        Component ram6GB = new Component("RAM", 200, "6GB");
        Component ram4GB = new Component("RAM", 130, "4GB");
        Computer CheapPC = new Computer("Cheap", new List<Component>() { mb1, prAMD, grCard512MB, ram4GB });
        Computer MiddlePC = new Computer("Middle", new List<Component>() { mb2, prIntel, grCard1GB, ram6GB });
        Computer ExpencivePC = new Computer("Expencive", new List<Component>() { mb3, prIntel, grCard2GB, ram8GB });

        List<Computer> listOfPCs = new List<Computer>() { CheapPC, MiddlePC, ExpencivePC };
        var orderedPCs = listOfPCs.OrderByDescending(pc => pc.PcPrice);
        foreach (var pc in orderedPCs)
        {
            Console.WriteLine(pc.ToString()+"\n");
        }
    }
}