using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter Rectangle Side A: ");
            uint a = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter Rectangle Side B: ");
            uint b = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter Square Side C: ");
            uint c = Convert.ToUInt32(Console.ReadLine());

            // check if square can be fit in both width and height
            if (c > a || c > b)
            {
                Console.WriteLine("[ERROR]: Square With Side C Can't Be Placed Inside Rectangle");
            }
            else
            {
                // calculate how many squares can be fit in rectangle
                uint squaresInWidth = a / c;
                uint squaresInHeight = b / c;
                uint totalSquares = squaresInWidth * squaresInHeight;

                // calculate total rectangle area
                uint rectangleArea = a * b;

                // calculate total used area (by squares)
                uint usedArea = totalSquares * c * c;

                // calculate total unused area
                uint unusedArea = rectangleArea - usedArea;

                // log results
                Console.WriteLine("Squares That Can Fit In Rectangle: " + totalSquares);
                Console.WriteLine("Unused Area Of Rectangle: " + unusedArea);
            }
        }
    }
}
