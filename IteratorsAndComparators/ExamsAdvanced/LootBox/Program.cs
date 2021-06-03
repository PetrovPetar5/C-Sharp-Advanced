using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBox = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            var secondBox = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            var claimedItems = 0;
            var goalToReach = 100;
            while (firstBox.Any() && secondBox.Any())
            {
                var firstBoxItem = firstBox.Peek();
                var secondBoxItem = secondBox.Peek();
                var CurBoxesValue = firstBoxItem + secondBoxItem;
                if (CurBoxesValue % 2 == 0)
                {
                    firstBox.Dequeue();
                    secondBox.Pop();
                    claimedItems += CurBoxesValue;
                }
                else
                {
                    secondBox.Pop();
                    firstBox.Enqueue(secondBoxItem);
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItems >= goalToReach)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}
