using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        long currentEast = 0;
        long totalPasses = 0;
        foreach(var car in A)
        {
            if(car == 0)
            {
                currentEast++;
            }
            else
            {
                totalPasses += currentEast;
            }
        }

        if(totalPasses > 1000000000)
        {
            return -1;
        }
        else
        {
            return (int)totalPasses;
        }
    }
}