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
            //Sample One
            WriteLine("Hello TDN!");
            Customer customer = new Customer();
            WriteLine(customer.customerID);
            string combindedString = string.Join(",", customer.customerNames.ToArray());
            WriteLine(combindedString);
            ReadLine();
        }
    }

    public class Customer
    {
        //Sample 2
        //public Customer()
        //{
        //    customerID = Guid.NewGuid();
        //}

        //public Guid customerID { get; protected set; }
        public Guid customerID { get; } = Guid.NewGuid();

        //Sample 3
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
