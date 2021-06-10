namespace Stack
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var endCommand = "END";
            var command = Console.ReadLine();
            var customStack = new CustomStack<string>();
            while (command != endCommand)
            {
                var commandArgs = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                try
                {
                    switch (commandArgs[0])
                    {
                        case "Pop":
                            customStack.Pop();
                            break;
                        case "Push":
                            var elements = commandArgs.Skip(1).ToArray();
                            customStack.Push(elements);
                            break;
                    }
                }
                catch (InvalidOperationException message)
                {

                    Console.WriteLine(message.Message);
                }

                command = Console.ReadLine();
            }

            PrintsAllElements(customStack);
            PrintsAllElements(customStack);
        }
        private static void PrintsAllElements(CustomStack<string> customStack)
        {
            foreach (var element in customStack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
