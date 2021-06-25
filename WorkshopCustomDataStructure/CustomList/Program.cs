namespace CustomList
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var ourList = new CustomList<string>();
            ourList.Add("Tesla A");
            ourList.Add("Tesla B");
            ourList.Add("Tesla C");
            ourList.Add("Tesla D");
            ourList.Add("Tesla Q");
            Console.WriteLine(ourList.Find("Tesla Q"));
            Console.WriteLine(ourList.Find("Tesla F"));
            ourList.Reverse();
            ourList.RemoveAt(0);
            ourList.Insert(4, "Spaceship X");
            ourList.Contains("Lamborghini Avantador");
            ourList.Swap(2, 4);
        }
    }
}
