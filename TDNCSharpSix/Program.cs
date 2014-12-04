using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace TDNCSharpSix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample One - Static Using Syntax
            WriteLine("Hello TDN!");
            //Sample Two - Auto-Property Initializers
            Customer customer = new Customer();
            WriteLine(customer.customerID);
            //Sample Three - Dictionary Initializers
            string combindedString = string.Join(",", customer.customerNames.ToArray());
            WriteLine(combindedString);
            //Sample Four - 
            ReadLine();
        }
    }

    public class Customer
    {
        //Sample 2 - OLD WAY - Auto-Property Initializers
        //public Customer()
        //{
        //    customerID = Guid.NewGuid();
        //}

        //public Guid customerID { get; protected set; }

        public Guid customerID { get; set; } = Guid.NewGuid();

        //Sample 3 - OLD WAY - Dictionary Initializers
        //public Dictionary<string, string> customerNames = new Dictionary<string, string>()
        //    {
        //        { "Michael Jordon", "Basketball" },
        //        { "Peyton Manning", "Football" },
        //        { "Babe Ruth", "Baseball" }
        //    };


        public Dictionary<string, string> customerNames = new Dictionary<string, string>()
        {
            ["Michael Jordon"] = "Basketball",
            ["Peyton Manning"] = "Football",
            ["Babe Ruth"] = "Baseball"
        };

    }

    }
