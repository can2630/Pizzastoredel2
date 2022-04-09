using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Pizzadel2
{

    class MenuCatalog
    {
        Dictionary<int, Pizza> pizzas;

        public MenuCatalog()

        {
            pizzas = new Dictionary<int, Pizza>();

        }

        public void CreatePizza(Pizza pizza)
        {

            pizzas.Add(pizza.Number, pizza);

        }

        public Pizza ReadPizza(int number)
        {
            return pizzas[number];
        }

        public void UpdatePizza(Pizza pizza)
        {
            Pizza p = ReadPizza(pizza.Number);
            p.Name = pizza.Name;
            p.Price = pizza.Price;
        }

        public void DeletePizza(Pizza pizza)

        {
            pizzas.Remove(pizza.Number);
        }


        public void PrintMenu()
        {
            foreach (var p in pizzas)
                Console.WriteLine($"{p.Value.Number} {p.Value.Name}{p.Value.Price} ");

        }


        public Pizza Search(string name)
        {
            return pizzas.FirstOrDefault(a => a.Value.Name.Contains(name)).Value;

        }


        public int MenuChoice(List<string> menuItems)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("--------------Menu Option---------------------");
            Console.WriteLine("----------------------------------------------");
            int index = 1;
            foreach (string choice in menuItems)



            {

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"{index}, {choice}");


                index++;
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("-----------------choose Menu--------------------");
            Console.WriteLine("------------------------------------------------");

            string selected = Console.ReadLine();

            int selectedint = menuItems.IndexOf(menuItems.Find(a => a.ToUpper().Contains(selected.ToUpper()))) + 1;

            if (selectedint == 0)
            {

                Console.WriteLine("error");
            }



            return selectedint;

        }


    }
}












