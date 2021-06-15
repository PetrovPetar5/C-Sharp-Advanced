namespace CustomList
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var ourList = new CustomList<int>();
            ourList[0] = 1;
            ourList[1] = 2;
        }
    }
}
