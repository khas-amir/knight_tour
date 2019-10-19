using System;
using System.Collections.Generic;


namespace Ход_конем
{

    class KnightTour
    {
        public int[,] board;
        private int boardRow;
        private int boardCol;
        private  List<int[]> directions = new List<int[]>()
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
        private List<int[]> moves;
        public KnightTour(int row, int col, int startX, int startY)
        {
            boardCol = col;
            boardRow = row;
            board = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    board[i, j] = -1;
                }
            }                             
            board[startX, startY] = 1;
            moves = new List<int[]>();
            moves.Add(new int[] { startX, startY });
            if (!possibleMoves(startX, startY, 2)) {
                throw new Exception();
            }
        }

        

      
        private bool isSafe(int x, int y)
        {
            return (x < boardCol && y < boardRow &&
                    x >= 0 && y >= 0 && board[x, y] == -1);          
        }
        private bool possibleMoves(int x, int y, int moveCounter)
        {
            
            if (moves.Count == boardCol * boardRow)
            {
                return true;
            }
            int i;
            int next_x, next_y;
            for(i = 0; i < 8; i++)
            {
                next_x = x + directions[i][0];
                next_y = y + directions[i][1];
                if (isSafe(next_x, next_y))
                {
                    board[next_x, next_y] = moveCounter;
                    moves.Add(new int[] { next_x, next_y });
                    if (possibleMoves(next_x, next_y, moveCounter + 1)) 
                        return true;
                    else
                    {
                        board[next_x, next_y] = -1;
                        moves.RemoveAt(moves.Count - 1);
                    }
                }
            }
            return false;
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
