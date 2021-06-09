namespace ListyIterator
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var endCommand = "END";
            var inputData = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Skip(1)
                                    .ToArray();
            var customList = new ListyIterator<string>(inputData);

            var command = Console.ReadLine();
            while (command != endCommand)
            {
                try
                {
                    switch (command)
                    {

                        case "HasNext":
                            Console.WriteLine(customList.HasNext());
                            break;
                        case "Move":
                            Console.WriteLine(customList.Move());
                            break;
                        case "Print":
                            customList.Print();
                            break;
                    }
                }
                catch (InvalidOperationException m)
                {

                    Console.WriteLine(m.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
