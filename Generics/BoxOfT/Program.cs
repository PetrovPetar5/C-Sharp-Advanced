namespace BoxOfT
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var intBox = new Box<int>();
            intBox.Add(5002);
            intBox.Add(5006);
            intBox.Add(5003);

            Console.WriteLine(intBox.Remove());

            var doubleBox = new Box<double>();
            doubleBox.Add(2.29);
            doubleBox.Add(2.29);
            Console.WriteLine(doubleBox.Remove());
        }
    }
}
