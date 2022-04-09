using System;
using System.Collections.Generic;
using System.Text;
namespace Pizzadel2
{
    public class Customer
    {
        private int    customerID;
        private string customername;
        private string customerNumber;
        private string customerAdress;


        public Customer(int customerID, string customername, string customerNumber, string customerAdress)
        {

            this.customerID = customerID;
            this.customername = customername;
            this.customerNumber = customerNumber;
            this.customerAdress = customerAdress;        
        }
        

        public int CustomerID
        {
            get { return this.customerID;}
            set { this.customerID = value;}
        }

        
         public string CustomerName

        {

            get { return this.customername; }
            set { this.customername = value; }

        }

        public string CustomerNumber

        {

            get { return this.customerNumber; }
            set { this.customerNumber = value; }

        }

        public string CustomerAdress
        { 
            get { return this.CustomerAdress; }
            set { this.CustomerAdress = value; }
        }


        public override string ToString()
        {
            return $" ID: { CustomerID} , Navn: { CustomerName} , mobil: {CustomerNumber} , Adresse: {customerAdress}";
        }



























    }
}
