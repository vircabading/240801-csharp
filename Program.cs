namespace algo.csharp.twonumberabsolutesumclosesttozero;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.ComponentModel;

class Program
{
    private static List<int> RetrieveInput()
    {
        List<int> numList = new List<int>();
        while (numList.Count == 0)
        {
            try
            {
                Console.WriteLine("Input an array of integers seperated by a space each:");
                string input = Console.ReadLine() ?? "";
                numList = Array.ConvertAll<string, int>(input.Split(" "), int.Parse).ToList<int>();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:\n{e.Message}");
            }
        }
        return numList;
    }

    public static void FindIndexes(IEnumerable<int> numList)
    {
        int minAbsoluteSum = int.MaxValue;
        int leftIndex = -1;
        int rightIndex = -1;

        for (int x=0; x < (numList.Count()-1); x++)
        {
            for (int y=x+1; y<numList.Count(); y++)
            {
                Console.WriteLine($"{x}, {y}");
                int sum = Math.Abs(numList.ElementAt(x) + numList.ElementAt(y));
                if (sum < minAbsoluteSum)
                {
                    minAbsoluteSum = sum;
                    leftIndex = x;
                    rightIndex = y;
                }
            }
        }

        Console.WriteLine($"The smallest absolute sum of {minAbsoluteSum} for numbers {numList.ElementAt(leftIndex)} and {numList.ElementAt(rightIndex)}");
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("**************************************");
        Console.WriteLine("Algorithm Find Two Numbers whose sum is closest to zero");
        Console.WriteLine("**************************************\n");
        List<int> numList = RetrieveInput();

        foreach (int num in numList)
        {
            Console.WriteLine(num);
        }

        Program.FindIndexes(numList);
    }
}