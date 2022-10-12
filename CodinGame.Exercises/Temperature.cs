using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Temperature
{
   public static void Calcule(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');

        int minDiff = int.MaxValue, result = 0;

        if (n == 0)
            minDiff = 0;

        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
            int abs = Math.Abs(t - 0);

            if (abs < minDiff || (abs == minDiff && t >= 0))
            {
                result = t;
                minDiff = abs;
            }
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}

