using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var array = ArrayCreator.Create(55, "Viki");
            Console.WriteLine(String.Join(", ", array));
        }
    }
}
