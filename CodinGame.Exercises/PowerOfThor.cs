using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class PowerOfThor
{
    static void Calcule(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        string nextMove = string.Empty;

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            if (initialTx > lightX)
            {
                if (initialTy > lightY)
                {
                    nextMove = "NW";
                    initialTx--;
                    initialTy--;
                }
                else if (initialTy < lightY)
                {
                    nextMove = "SW";
                    initialTx--;
                    initialTy++;
                }
                else
                {
                    nextMove = "W";
                    initialTx--;
                }
            }
            else if (initialTx < lightX)
            {
                if (initialTy > lightY)
                {
                    nextMove = "NE";
                    initialTx++;
                    initialTy--;
                }
                else if (initialTy < lightY)
                {
                    nextMove = "SE";
                    initialTx--;
                    initialTy++;
                }
                else
                {
                    nextMove = "E";
                    initialTx--;
                }
            }
            else
            {
                if (initialTy > lightY)
                {
                    nextMove = "N";
                    initialTy--;
                }
                else if (initialTy < lightY)
                {
                    nextMove = "S";
                    initialTy++;
                }
            }


            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(nextMove);
        }
    }
}