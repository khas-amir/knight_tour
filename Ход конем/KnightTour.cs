using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ход_конем
{
    class KnightTour
    {
        private int[,] board;
        private List<int[]> moves;
        private int times;
        private int  position = 1;

        private List<int[]> directions = new List<int[]>()
        {
            new int[] { 2, 1 },
            new int[] { 1, 2 },
            new int[] { -1, 2 },
            new int[] { -2, 1 },
            new int[] { -2, -1 },
            new int[] { -1, -2 },
            new int[] { 1, -2 },
            new int[] { 2, -1 }
        };

        public KnightTour(int row, int col, int startX, int startY)
        {

            board = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.Board[i, j] = 0;
                }
            }
            moves = new List<int[]>();
            times = row * col;
            moveKnight(startX, startY);
        }

        public int[,] Board => board;

      
        private bool isSafe(int x, int y)
        {
            if (x < Board.GetLength(0) && y < Board.GetLength(1) &&
                    x >= 0 && y >= 0)
            {

                return (Board[x, y] == 0);
            }
            return false;
        }
        private void moveKnight(int newX, int newY)
        {
            board[newX, newY] = position;            
            if (position == times)
            {
                return;
            }
            position++;
            possibleMoves(newX, newY);
        }
        private void possibleMoves(int startX, int startY)
        {
            for(int i = 0; i < directions.Count; i++)
            {
                int currX = startX + directions[i][0];
                int currY = startY + directions[i][1];
                if (isSafe(currX, currY))
                {
                    moveKnight(currX, currY);                    
                }
            }
            
        }

    }

    public static class ArraysExtensions
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void Init<T>(this T[] array, T defaultVaue)
        {
            if (array == null)
                return;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = defaultVaue;
            }
        }

    }
}
