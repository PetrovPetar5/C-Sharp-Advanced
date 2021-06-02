using System;
using System.Linq;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var customStackData = new CustomStack<string>();
            var command = String.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                var commandArgs = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var commandType = commandArgs[0];
                try
                {
                    switch (commandType)
                    {
                        case "Push":
                            var collectionToAdd = commandArgs.Skip(1).ToList();
                            customStackData.Push(collectionToAdd);
                            break;
                        case "Pop":
                            customStackData.Pop();
                            break;
                    }
                }
                catch (InvalidOperationException msg)
                {
                    Console.WriteLine(msg.Message);
                }
            }

            if (customStackData.Data.Count != 0)
            {
                PrintsEachElementOnTheConsole(customStackData);
                PrintsEachElementOnTheConsole(customStackData);
            }
        }

        private static void PrintsEachElementOnTheConsole(CustomStack<string> customStackData)
        {

            foreach (var item in customStackData)
            {
                Console.WriteLine(item);
            }
        }
    }
}
