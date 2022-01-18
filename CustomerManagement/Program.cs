using System;
using TurboCollections;

namespace CustomerManagement
{
    class Program
    {
        public static TurboList<string> _customerList = new ();
        static void Main()
        {
            bool run = true;

            if (run)
            {
                SomeText();
            }
        }


        private static void SomeText()
        {
            Console.WriteLine("Choose one option:");
            Console.WriteLine("(1) Add a customer");
            Console.WriteLine("(2) Remove a customer by name");
            Console.WriteLine("(3) Remove a Customer by index");
            Console.WriteLine("(4) Display all customers");
            var str = Console.ReadLine();
            int i = 0;

            if (int.TryParse(str, out i))
            {
                if (i is > 0 and < 5)
                {
                    InputSomething(i);
                }
                else
                {
                    Console.WriteLine("Invalid Input, ty again");
                    Main();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input, ty again");
                Main();
            }
            
        }

        private static void InputSomething(int input)
        {
            switch (input)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    RemoveCustomerByName();
                    break;
                
                case 3:
                    
                    break;
                case 4:
                    
                    break;
            }
        }

        private static void AddCustomer()
        {
            Console.WriteLine("What is the customer's name?");
            var str = Console.ReadLine();
            
            _customerList.Add(str);
            Main();
        }
        
        private static void RemoveCustomerByName()
        {
            Console.WriteLine("What is the customer's name?");
            var str = Console.ReadLine();
            
        }
    }
}