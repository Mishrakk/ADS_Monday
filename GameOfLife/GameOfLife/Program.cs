using System;
/* 
 * 1. 2D grid
 * 2. Every cell is dead or alive 
 * 3. At each new generation 
 * 4. If a cell is alive 
 * 5. Neighbours 0,1=Dead
 * 6. Neighbours 2,3=Alive
 * 7. Neighbours 4 or more = dead
 * 8. If a cell is dead and Neighbours 3 = alive 
 * 9. Otherwise cell = dead
 * 
 */
namespace GameOfLife
{

    class Program
    {
        static void Main(string[] args)
        {
            bool[,] grid = new bool[10, 10];//True is alive,False is dead


        }
    }
}
