using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var lilies = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            var roses = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            var neededForWreath = 15;
            var wreathsGoal = 5;
            var storedFlowers = 0;
            var wreathsMade = 0;
            while (lilies.Any() && roses.Any())
            {
                var curLilly = lilies.Pop();
                var curRose = roses.Dequeue();
                var bothFlowersFig = curLilly + curRose;
                if (bothFlowersFig == neededForWreath)
                {
                    wreathsMade++;

                }
                else if (bothFlowersFig < neededForWreath)
                {
                    storedFlowers += bothFlowersFig;
                }
                else
                {
                    var stored = false;
                    while (bothFlowersFig != 15)
                    {
                        bothFlowersFig -= 2;
                        if (bothFlowersFig < neededForWreath)
                        {
                            storedFlowers += bothFlowersFig;
                            stored = true;
                            break;
                        }
                    }

                    if (!stored)
                    {
                        wreathsMade++;
                    }
                }
            }

            wreathsMade += storedFlowers / neededForWreath;
            if (wreathsMade >= wreathsGoal)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsMade} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {wreathsGoal - wreathsMade} wreaths more!");
            }
        }
    }
}
