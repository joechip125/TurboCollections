using System;
using TurboCollections;

namespace GameStateHistory
{
    class Program
    {
        public static TurboStack<int> levelStack = new TurboStack<int>();
        public static string CurrentLocation = "MainMenu";
        
        static void Main()
        {
            
        }

        private static void InitStack(int stackCount)
        {
            for (int i = 0; i < stackCount; i++)
            {
                levelStack.Push(i);
            }
        }

        private static void SomeText()
        {
            levelStack.Push(levelStack.Peek() + 1);
            Console.WriteLine("You are here: " + CurrentLocation);
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("(0) Go to level ");
            
        }

        
    }
}