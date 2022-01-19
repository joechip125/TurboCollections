using System;
using System.Collections.Generic;
using TurboCollections;

namespace TurboShuntingYard
{
    public enum TokenType {Number, Operator, Parenthesis, None}
    
    class Operator
    {
        public string Name { get; set; }
        public int Precedence { get; set; }
        public bool RightAssociative { get; set; }
    }
    
    class Program
    {
        private TurboStack<char> operatorStack;
        private static TurboQueue<char> outputQueue;
        
        private static IDictionary<string, Operator> operators = new Dictionary<string, Operator>
        {
            ["+"] = new Operator { Name = "+", Precedence = 1 },
            ["-"] = new Operator { Name = "-", Precedence = 1 },
            ["*"] = new Operator { Name = "*", Precedence = 2 },
            ["/"] = new Operator { Name = "/", Precedence = 2 },
            ["^"] = new Operator { Name = "/", Precedence = 3, RightAssociative = true }
        };
        
        static void Main()
        {
            Console.WriteLine("Input math formula: ");
            string str = Console.ReadLine();
            
            IterateOverString(str);
        }


        private static TokenType CheckChar(char ch)
        {
            TokenType type = TokenType.None;
            
            if (char.IsDigit(ch))
            {
                return TokenType.Number;
            }

            if (operators.ContainsKey(Convert.ToString(ch)))
            {
                return TokenType.Operator;
            }

            throw new Exception("Wrong character");
        }
        
        private static void IterateOverString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str.GetEnumerator().MoveNext();
                char currentChar = str.GetEnumerator().Current;

                TokenType type = CheckChar(currentChar);

                if (type == TokenType.Number)
                {
                    outputQueue.Enqueue(currentChar);
                }
            }
        }
        
    }
}