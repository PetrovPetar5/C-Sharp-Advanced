namespace ListyIterator
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var endCommand = "END";
            var inputData = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Skip(1)
                                    .ToArray();
            var customList = new ListyIterator<string>(inputData);

            foreach (var item in customList)
            {
                Console.WriteLine(item);
            }

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
                        case "PrintAll":
                            Console.WriteLine(customList.PrintAll());
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
