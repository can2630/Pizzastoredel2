using System;
namespace Pizzadel2
{
    class Pizza
    {


    public int Number { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

        public Pizza(int number, string name, double price)
        {
            Number = number;
            Name = name;
            Price = price;
        }
        
        public override string ToString()
        {
            return $"Number: {Number} Name: {Name} Price: {Price}";
        }
    }
}


