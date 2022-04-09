using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;


namespace Pizzadel2
{
    class CustomerCatalog
    {

        Dictionary<int, Customer> customers;

        public CustomerCatalog()
        {
            customers = new Dictionary<int, Customer>();

        }

        public void CreateCustomer(Customer customer)
        {
            customers.Add(customer.CustomerID, customer);

        }

        public Customer ReadCustomer(int ID)
        {
            return customers[ID];

        }

        public void UpdateCustomer(Customer customer)
        {

            Customer c = ReadCustomer(customer.CustomerID);
            c.CustomerID = customer.CustomerID;
            c.CustomerName = customer.CustomerName;
            c.CustomerNumber = customer.CustomerNumber;
            c.CustomerAdress = customer.CustomerAdress;

        }

            public void DeleteCustomer(Customer customer)
            {

                customers.Remove(customer.CustomerID);

            }

            public void PrintCustomer()
            {
                foreach (var c in customers)
                {
                    Console.WriteLine($"{c.Value.CustomerID} {c.Value.CustomerName} {c.Value.CustomerNumber} {c.Value.CustomerAdress} ");
                }
            }


        public Customer Search(string name)
        {
            return customers.FirstOrDefault(a => a.Value.CustomerName.Contains(name)).Value;
        }


        





        }
    }





















    













