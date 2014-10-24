using System;

class TestLaptop
{
    static void Main()
    {
        Laptop LevonovoYoga = new Laptop("Lenovo Yoga 2 Pro", 2259.00, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", 128, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", "Li-Ion, 4-cells, 2550 mAh", 4.5);
        Console.WriteLine(LevonovoYoga.ToString());
        Console.WriteLine();
        Laptop HPG2 = new Laptop("HP 250 G2", 699.00);
        Console.WriteLine(HPG2.ToString());
        Console.WriteLine();
        Laptop HPtest = new Laptop("HP random", 599.50, "HP", null, 6);
        Console.WriteLine(HPtest.ToString());
    }
}