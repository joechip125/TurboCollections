using System;
using TurboCollections;

namespace GameStateHistory
{
    class Program
    {
        public static TurboStack<int> levelStack = new TurboStack<int>();
        public static string CurrentLocation = "Main Menu";

        public static int nextLevel = 1;

        private static TurboLinkedStack<int> stack = new (1);
        
        static void Main()
        {
           stack.Push(2);
           stack.Push(3);
           stack.Push(4);
           stack.Push(5);
           stack.RemoveFromFront();
           stack.PrintList();
        }

   

        private static void SomeText()
        {
            levelStack.Push(levelStack.Peek() + 1);
            Console.WriteLine("You are here: " + CurrentLocation);
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("(0) Go to level " + nextLevel);
            Console.WriteLine("(1) Go to level ");
            
            if (CurrentLocation != "Main Menu")
            {
                Console.WriteLine("(b) Go back to main menu");
            }
            

            var str = Console.ReadLine();
            int i = 0;
            
            if (int.TryParse(str, out i))
            {
                
            }
            else if (CurrentLocation != "Main Menu" && str == "b")
            {
                
            }

            else
            {
                Console.WriteLine("Invalid selection, try again");
            }

        }

        
    }
}