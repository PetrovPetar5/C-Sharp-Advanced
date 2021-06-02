using System;
using System.Collections.Generic;
using System.Linq;
namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var inputData = ReturnsInputAsCollection(command);
            var listyIterator = new ListyIterator<string>(inputData);
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    switch (command)
                    {
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "PrintAll":
                            Console.WriteLine(listyIterator.PrintAll());
                            break;
                    }
                }
                catch (InvalidOperationException em)
                {

                    Console.WriteLine(em.Message);
                }
            }
        }
        private static List<string> ReturnsInputAsCollection(string command)
        {
            var commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var inputData = commandArgs.Skip(1).ToList();
            if (inputData.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return inputData;
        }
    }
}
