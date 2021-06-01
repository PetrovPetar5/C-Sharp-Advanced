namespace BoxOfT
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            box.Add("Love is all a person needs");
            box.Add("need a beer?");
            box.Add("A lovely portrait on that wall isn it?");
            Console.WriteLine(box.Remove());
            box.Add("Shame on you you have eaten all the food left?");
            Console.WriteLine(box.Remove());
        }
    }
}
