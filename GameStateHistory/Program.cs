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
        private static TurboLinkedQueue<int> queue = new (1);
        private static TurboQueue<int> aQueue = new TurboQueue<int>();
        private static TurboBinarySearchTree binaryTree = new TurboBinarySearchTree();

        static void Main()
        {
            string someString = "Blerk";
            var ch = someString.ToCharArray();
            var code = ch[4].GetHashCode() % 8;
            int someInt = 3466 % 7;
            Console.WriteLine(code);
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