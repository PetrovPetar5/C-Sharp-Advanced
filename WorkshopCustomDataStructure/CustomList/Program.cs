namespace CustomList
{
    using System;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            var ourList = new CustomList<string>();
            ourList.Add("Doremia");
            ourList.Add("Doremids");
            ourList.Add("Doremisda");
            ourList.Add("Doremi");

            
            Console.WriteLine(ourList.Find("Kuro"));

        }
    }
}
