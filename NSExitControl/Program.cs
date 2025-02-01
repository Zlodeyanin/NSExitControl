using System;

namespace NSExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exitCommand = "exit";
            string userInput = "";

            while (userInput != exitCommand)
            {
                Console.WriteLine("Цикл работает, введите exit для выхода: ");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Вы вышли из цикла.");
            Console.ReadKey();
        }
    }
}
