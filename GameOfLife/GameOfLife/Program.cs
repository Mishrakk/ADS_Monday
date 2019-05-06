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
            PrintGrid(grid);
            grid[1, 1] = true;
            grid[2, 1] = true;
            grid[3, 1] = true;
            //boat
            /*grid[5, 5] = true;
            grid[6, 5] = true;
            grid[5, 6] = true;
            grid[7, 6] = true;
            grid[6, 7] = true;
            grid[7, 7] = true;*/
            //glider
            grid[0, 4] = true;
            grid[2, 4] = true;
            grid[1, 5] = true;
            grid[2, 5] = true;
            grid[1, 6] = true;
            PrintGrid(grid);
            for(int t = 0; t < 100; t++)
            {
            grid = CreateNewGeneration(grid);
            PrintGrid(grid);


            }
        }

        public static bool [,] CreateNewGeneration(bool[,] grid) {
            bool[,] NewGrid = new bool[10, 10];
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    int Count = 0;
                    if (grid[(x-1+10)%10, (y-1+10)%10])
                    {
                        Count++;
                    }
                    if (grid[x, (y-1+10)%10])
                    {
                        Count++;
                    }
                    if (grid[(x+1)%10, (y-1+10)%10])
                    {
                        Count++;
                    }
                    if (grid[(x-1+10)%10, y])
                    {
                        Count++;
                    }
                    if (grid[(x+1)%10, y])
                    {
                        Count++;
                    }
                    if (grid[(x-1+10)%10, (y+1)%10])
                    {
                        Count++;
                    }
                    if (grid[x, (y+1)%10])
                    {
                        Count++;
                    }
                    if (grid[(x+1)%10, (y+1)%10])
                    {
                        Count++;
                    }

                    if (grid[x, y])
                    {
                        if(Count==2 || Count == 3)
                        {
                            NewGrid[x, y] = true;
                        }
                        else
                        {
                            NewGrid[x, y] = false;
                        }
                    }
                    else
                    {
                        if (Count == 3)
                        {
                            NewGrid[x, y] = true;
                        }
                        else
                        {
                            NewGrid[x, y] = false;
                        }

                    }
                }

            }
            return NewGrid;
        }

        public static void PrintGrid(bool[,] grid)
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (grid[x, y] == true)
                    {
                        Console.Write("A");
                    }
                    else
                    {
                        Console.Write("D");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
