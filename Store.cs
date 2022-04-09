using System;
using System.Collections.Generic;
using System.Text;
namespace Pizzadel2
{
    public class Store
    {

        public void Start()

        {
            Test();

        }


        public void Test()
        {
            MenuCatalog menuCat = new MenuCatalog();

            Pizza p1 = new Pizza(1, "pepperonipizza", 60);
            Pizza p2 = new Pizza(2, "salatpizza", 60);
            Pizza p3 = new Pizza(1, "barca", 50);
            Pizza p4 = new Pizza(4, "skinkepizza", 65);
            menuCat.CreatePizza(p1);
            menuCat.CreatePizza(p2);
            menuCat.CreatePizza(p4);

            CustomerCatalog customerCat = new CustomerCatalog();

            Customer c1 = new Customer(52, "Lasse Andersenn", "31675992", "Holmergade 12");
            Customer c2 = new Customer(12, "Søren jespersen,", "56437927", "Stellavej 2");
            Customer c3 = new Customer(5, "Sara Andersen", "39612681", "Engvej 12");
            Customer c4 = new Customer(16, "Per Jensen", "42967305", "Perlelunden 43");

            customerCat.CreateCustomer(c1);
            customerCat.CreateCustomer(c2);
            customerCat.CreateCustomer(c3);
            customerCat.CreateCustomer(c4);

            Console.WriteLine("Pizza created:");
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine(menuCat.ReadPizza(1));

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Reading pizzas:");
            Console.WriteLine(menuCat.ReadPizza(1));
            Console.WriteLine(menuCat.ReadPizza(2));

            menuCat.UpdatePizza(p3);
            Console.WriteLine(menuCat.ReadPizza(1));

            menuCat.DeletePizza(p1);
            try
            {
                Console.WriteLine(menuCat.ReadPizza(1));
            }
            catch
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Pizza Not found");


            }

            Console.WriteLine("-------------------------------------------------");


          

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("----------------print information-----------------");
            Console.WriteLine("--------------------------------------------------");

            menuCat.PrintMenu();

            
            List<string> menulist = new List<string>();
            menulist.Add("Create a new Pizza");
            menulist.Add("search for a pizza");
            menulist.Add("update a pizza");
            menulist.Add("delete a pizza");
            menulist.Add("display pizza menu");
            menulist.Add("Exit");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("");

            int menuchoic = menuCat.MenuChoice(menulist);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");

            Pizza searched = menuCat.Search("skinkepizza");

            Customer searchedCustomer = customerCat.Search("Lasse Andersenn");

            
            Console.WriteLine(searchedCustomer.ToString());

            Console.WriteLine($"selected pizza   :   {searched.Number} , {searched.Name} , price = {searched.Price} kr");

            Console.ReadLine();

        }
    }

}