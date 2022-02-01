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
            binaryTree.Insert(3);
            binaryTree.Insert(27);
            binaryTree.Insert(678);
            binaryTree.Insert(89);
            binaryTree.Insert(45);
            binaryTree.Insert(126);
            binaryTree.TraverseInOrder(binaryTree.RootNode);
            binaryTree.Delete(89);
            Console.WriteLine("    ");
            binaryTree.TraverseInReverseOrder(binaryTree.RootNode);
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