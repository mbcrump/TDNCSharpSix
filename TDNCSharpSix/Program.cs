using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;
using System.Net;

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
            //Sample Four - Error Handling

            try
            {
                throw new Exception("Error");
            }
            catch (Exception ex) if (ex.Message == "ReallyBadError")
            {
                // this one will not execute.
            }
            catch (Exception ex) if (ex.Message == "Error")
            {
                // this one will execute
                WriteLine("This one will execute");
            }

            //Sample 5 - async/await
            Task task = new Task(DownloadAsync);
            task.Start();
            task.Wait();

            ReadLine();
        }

        public static async void DownloadAsync()
        {
            try
            {
                throw new Exception("Error");
            }
            catch
            {
                await Task.Delay(2000);
                WriteLine("Waiting 2 seconds");
            }
            finally
            {
                await Task.Delay(2000);
                WriteLine("Waiting 2 seconds");
                 
            }
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
