using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoDimensIonalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //NumIslands(new char[][] { new char[] { '1', '1', '0', '0', '0' }, new char[] { '1', '1', '0', '0', '0' },
            //    new char[] { '0', '0', '1', '0', '0' } , new char[] { '0', '0', '0', '1', '1' } });
            FindOrder(4, new int[][] { new int[] { 1, 0 }, new int[] { 2, 0 }, new int[] { 3, 1 }, new int[] { 3, 2 } });
           // FindOrder(2, new int[][] { new int[] { 1, 0 }});
            WallsAndGates(new int[][] { new int[] { 2147483647, -1, 0, 2147483647 },
            new int[]{2147483647,2147483647,2147483647,-1}, new int[]{ 2147483647, -1, 2147483647, -1 }, new int[]{0,-1,2147483647,2147483647 } });
        }

        public static int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var list = new HashSet<int>();
            var dict = new Dictionary<int, HashSet<int>>();
            foreach(var item in prerequisites)
            {
                if(!dict.ContainsKey(item[1]))
                {
                    dict.Add(item[1], new HashSet<int> { item[0] });
                }
                else
                {
                    dict[item[1]].Add(item[0]);
                }
            }

            //var list
            foreach (var item in dict)
            {
                list.Add(item.Key);
                var hashset = item.Value;
                foreach (var value in hashset)
                    list.Add(value);
                if (numCourses == list.Count)
                {
                    return list.ToArray();
                }
               
            }

            return list.ToArray();
        }
        public static void WallsAndGates(int[][] rooms)
        {
            if (rooms == null || rooms.Length == 0)
                return;

            for (int i = 0; i < rooms.Length; i++)
            {
                for (int j = 0; j < rooms[i].Length; j++)
                {
                    if (rooms[i][j] == 0)
                    {
                        DFS(i, j, 0, rooms);
                    }
                }
            }
        }

        public static void DFS(int i, int j, int count, int[][] rooms)
        {
            if (i < 0 || j < 0 || i >= rooms.Length || j >= rooms[i].Length || rooms[i][j] < count)
                return;
            rooms[i][j] = count;
            DFS(i + 1, j, count + 1, rooms);
            DFS(i - 1, j, count + 1, rooms);
            DFS(i, j + 1, count + 1, rooms);
            DFS(i, j - 1, count + 1, rooms);
        }
        public static bool IsRectangle(int[,] matrix)
        {
            // finding row and column size 
            //int rows = matrix.Count;
            if (matrix.GetLength(0) == 0)
            {
                return false;
            }

            //int columns = matrix[0].Count;

            // map for storing the index of combination of 2 1's 
            //Dictionary<int, HashSet<int>> table = new Dictionary<int, HashSet<int>>();
            Dictionary<int, HashSet<int>> table = new Dictionary<int, HashSet<int>>();

            // scanning from top to bottom line by line 
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {

                for (int j = 0; j < matrix.GetLength(1) - 1; ++j)
                {
                    for (int k = j + 1; k < matrix.GetLength(1); ++k)
                    {

                        // if found two 1's in a column 
                        if (matrix[i, j] == 1 && matrix[i, j] == 1)
                        {

                            // check if there exists 1's in same 
                            // row previously then return true 
                            if (table.ContainsKey(j) && table[j].ElementAt(k) != table[j].Last())
                            {
                                return true;
                            }

                            if (table.ContainsKey(k) && table[k].ElementAt(j) != table[k].Last())
                            {
                                return true;
                            }
                            // store the indexes in hashset 
                            table[j].Add(k);
                            table[k].Add(j);
                        }
                    }
                }
            }
            return false;
        }

        public static bool CheckStraightLine(int[][] coordinates)
        {
            for (int i = 2; i < coordinates.Length; i++)
            {
                if ((coordinates[1][1] - coordinates[0][1]) * (coordinates[i][0] - coordinates[0][0])
                != (coordinates[1][0] - coordinates[0][0]) * (coordinates[i][1] - coordinates[0][1]))
                    return false;
            }

            return true;
        }
        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            //var newArray = image.Select(x=>x.ToArray()).ToArray();
            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < image.Length; j++)
                {
                    if (i == sr && j == sc)
                    {
                        var sameColor = image[i][j];
                        image[i][j] = newColor;
                        FloodFill(image, sr, sc, newColor, i, j, sameColor);
                    }
                }
            }

            return image;
        }

        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor, int i, int j, int sameColor)
        {
            if (i < 0 || j < 0 || i >= image.Length || j >= image.Length || image[i][j] == newColor)
                return null;
            image[i][j] = newColor;
            FloodFill(image, sr, sc, newColor, i + 1, j, sameColor);
            FloodFill(image, sr, sc, newColor, i - 1, j, sameColor);
            FloodFill(image, sr, sc, newColor, i, j + 1, sameColor);
            FloodFill(image, sr, sc, newColor, i, j - 1, sameColor);
            return image;
        }

        public static bool ValidTicTacToe(string[] board)
        {
            int xCount = 0, oCount = 0;
            char[] arr = (board[0] + board[1] + board[2]).ToCharArray();
            foreach (var item in arr)
            {
                if (item == 'O') oCount++;
                if (item == 'X') xCount++;
            }
            if (oCount != xCount && oCount + 1 != xCount)
                return false;
            int winState = GetWinState(arr[0], arr[4], arr[8]);
            winState += GetWinState(arr[6], arr[4], arr[2]);
            for (int i = 0; i < 3; i++)
            {
                winState += GetWinState(arr[i * 3], arr[i * 3 + 1], arr[i * 3 + 2]);
                winState += GetWinState(arr[i], arr[i + 3], arr[i + 6]);
            }
            return winState == 0 || (winState == -10 && oCount == xCount) || ((winState == 1 || winState == 2) && oCount + 1 == xCount);
        }
        private static int GetWinState(char c1, char c2, char c3)
        {
            if (c1 != ' ' && c1 == c2 && c2 == c3) return c1 == 'X' ? 1 : -10;
            else return 0;
        }

        public static int[,] RotateSquareMatrix(int[,] matrix)
        {
            int[,] returnMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            int row = 0;
            int column = 0;
            for (int cols = matrix.GetLength(1) - 1; cols >= 0; cols--)
            {
                column = 0;
                for (int rows = 0; rows <= matrix.GetLength(0) - 1; rows++)
                {
                    returnMatrix[row, column] = matrix[rows, cols];
                    column++;
                }
                row++;
            }
            for (int i = 0; i <= returnMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= returnMatrix.GetLength(1) - 1; j++)
                {
                    Console.Write(returnMatrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            return returnMatrix;
        }

        public int NumIslands(char[,] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }
            int islandCount = 0;
            for (int i = 0; i <= grid.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= grid.GetLength(1) - 1; j++)
                {
                    if (grid[i, j] == '1')
                    {
                        // Increment the count.
                        islandCount++;
                        // Change land to water.
                        LandToWater(grid, i, j);
                    }
                }
            }
            return islandCount;
        }
        public void LandToWater(char[,] grid, int i, int j)
        {
            // When i  is zero or i is greater than row length
            // When j is zero or j is greater than column length
            // When we encounter zero
            if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i, j] == '0') return;

            grid[i, j] = '0';

            // Check for all the neighbours, down, up, left and right.
            LandToWater(grid, i - 1, j); // down
            LandToWater(grid, i + 1, j); // up
            LandToWater(grid, i, j - 1); // left
            LandToWater(grid, i, j + 1); // right
        }


        public static int[] MeetingPlanner(int[,] slotsA, int[,] slotsB, int dur)
        {
            int ia = 0;
            int ib = 0;

            while (ia < slotsA.GetLength(0) && ib < slotsB.GetLength(0))
            {
                int start = Math.Max(slotsA[ia, 0], slotsB[ib, 0]);
                int end = Math.Min(slotsA[ia, 1], slotsB[ib, 1]);

                if (start + dur <= end)
                    return new int[] { start, start + dur };

                if (slotsA[ia, 1] < slotsB[ib, 1])
                    ia++;
                else
                    ib++;
            }
            return new int[] { };
        }

        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int islandCount = 0;
            int row = grid.Length;
            int col = grid[0].Length;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islandCount++;
                        NumIslands(grid, i, j);
                    }
                }
            }

            return islandCount;
        }

        public static void NumIslands(char[][] grid, int row, int col)
        {
            if (row < 0 || col < 0 || row > grid.Length - 1 || col > grid[row].Length - 1 || grid[row][col] == '0')
                return;
            grid[row][col] = '0';

            // Exlpore bottom.
            NumIslands(grid, row + 1, col);
            // Exlplore top.
            NumIslands(grid, row - 1, col);
            // Explore right.
            NumIslands(grid, row, col + 1);
            // Explore left.
            NumIslands(grid, row, col - 1);
        }
    }

    public class TicTacToe
    {
        int[] rows;
        int[] cols;
        int dc1;
        int dc2;
        int n;
        /** Initialize your data structure here. */
        public TicTacToe(int n)
        {
            this.n = n;
            this.rows = new int[n];
            this.cols = new int[n];
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            int val = (player == 1 ? 1 : -1);

            rows[row] += val;
            cols[col] += val;

            if (row == col)
            {
                dc1 += val;
            }
            if (col == n - row - 1)
            {
                dc2 += val;
            }

            if (Math.Abs(rows[row]) == n
            || Math.Abs(cols[col]) == n
            || Math.Abs(dc1) == n
            || Math.Abs(dc2) == n)
            {
                return player;
            }

            return 0;
        }
    }
}
