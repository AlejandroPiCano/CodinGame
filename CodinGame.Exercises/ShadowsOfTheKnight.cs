using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.Exercises
{
    internal class ShadowsOfTheKnight
    {
        static void Calcule(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]); // width of the building.
            int H = int.Parse(inputs[1]); // height of the building.
            int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
            inputs = Console.ReadLine().Split(' ');
            int X0 = int.Parse(inputs[0]);
            int Y0 = int.Parse(inputs[1]);

            // game loop
            while (true)
            {
                string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                if (bombDir == "U")
                {
                    if (Y0 > 0)
                        Y0--;
                }
                else if (bombDir == "D")
                {
                    if (Y0 < H)
                        Y0++;
                }
                else if (bombDir == "L")
                {
                    if (X0 > 0)
                        X0--;
                }
                else if (bombDir == "R")
                {
                    if (X0 < W)
                        X0++;
                }
                else if (bombDir == "UR")
                {
                    if (Y0 > 0 && X0 < W)
                    {
                        Y0--;
                        X0++;
                    }
                }
                else if (bombDir == "DR")
                {
                    if (Y0 < H && X0 < W)
                    {
                        Y0++;
                        X0++;
                    }
                }
                else if (bombDir == "DL")
                {
                    if (Y0 < H && X0 > 0)
                    {
                        Y0++;
                        X0--;
                    }
                }
                else if (bombDir == "UL")
                {
                    if (Y0 > 0 && X0 > 0)
                    {
                        Y0--;
                        X0--;
                    }
                }

                // the location of the next window Batman should jump to.
                Console.WriteLine($"{X0} {Y0}");
            }
        }
    }
}
