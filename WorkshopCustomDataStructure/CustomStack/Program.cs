namespace CustomStack
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var ourStack = new CustomStack<int>();
            ourStack.Push(422);
            ourStack.Push(42);
            ourStack.Push(413);
            ourStack.Peek();
            ourStack.Pop();

        }
    }
}
