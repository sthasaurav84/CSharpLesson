using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFirstname;
            string age;
            string address;

            //ask the user their name
            Console.WriteLine("What is your first name?");
            userFirstname = Console.ReadLine();

            //ask the user their age
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            //ask the address
            Console.WriteLine("What is your address?");
            address = Console.ReadLine();

            string response = "Your name is: " + userFirstname + 
                              " and you are " + age + " years old" + "Your address is: " + address;
            response = $"Your name is: {userFirstname} and you are {age} years old and Your address is {address}";
            Console.WriteLine(response);

            Console.WriteLine("Testing GIthub COmmit Push Pull and Merge");


            //FORMATTING TEST FOR OUTPUT
            //double pricePerOunce = 17.36;
            //var outputString = "The current price is " + pricePerOunce;
            //var outputString = string.Format("The current price is {0}", pricePerOunce);
            //var outputString = string.Format("The current price is {0:C}", pricePerOunce);

            //string itemName = "Widget";
            //var outputString = string.Format("{0,10} {1,10}", itemName, pricePerOunce);
            //Console.WriteLine(String.Format("{0,10} {1,10}", "Item Name", "Price"));

            //Console.WriteLine(outputString);

            //VERBATIM STRINGS AND ESCAPE SEQUENCES
            //string file = "c:\\file\\mine";
            //file = @"c:\file\mine";


        }
    }
}
