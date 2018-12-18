using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ход_конем
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }

        private struct ChessPoint
        {
            public Point point;
            public int move;
        }

        private ChessPoint[,] chessPoints;

        

        private static int[,] directions = new int[,] { { 2, 1 },
                                                       { 1, 2 },
                                                       { -1, 2 },
                                                       { -2, 1 },
                                                       { -2, -1 },
                                                       { -1, -2 },
                                                       { 1, -2 },
                                                       { 2, -1 } };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0; int m = 0;
            int x = 0; int y = 0;
            if (Int32.TryParse(n_textBox.Text, out n) &&
                Int32.TryParse(m_textBox.Text, out m) &&
                Int32.TryParse(x_textBox.Text, out x) &&
                Int32.TryParse(y_textBox.Text, out y)  )
            {
                if ( x <= n || y <= m || x > 0 || y > 0)
                {
                    InitChessPoints(n, m, x, y);
                    draw_board();
                } else
                {
                    MessageBox.Show("Текущая позиция вышла за границу массива");
                } 
            } else
            {
                MessageBox.Show("Неверные данные");
            }
        }

        public void InitChessPoints(int row, int col, int currX, int currY)
        {
            chessPoints = new ChessPoint[row, col];
            for (int i =  0; i < row; i++ )
            {
                for (int j = 0; j < col; j++ )
                {
                    chessPoints[i, j].move = 0;
                }
            }
            chessPoints[currX - 1, currY - 1].move = 1;

        }
        private void about_button_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        public void draw_board()
        {
            
            Graphics G = chess_board.CreateGraphics();
            G.Clear(Color.White);
            Pen p = new Pen(Color.Black);
            SolidBrush sb_black = new SolidBrush(Color.Black);
            SolidBrush sb_white = new SolidBrush(Color.White);
            const int SQUARE_LEN = 50;
            
            int x = 0;
            int y = 0;
            for (int i = 0; i < chessPoints.GetLength(0); i++)
            {
                for(int j = 0; j < chessPoints.GetLength(1); j++)
                {
                    Point[] points = new Point[4];
                    points[0] = new Point(x, y);
                    points[1] = new Point(x, y + SQUARE_LEN);
                    points[2] = new Point(x + SQUARE_LEN, y + SQUARE_LEN);
                    points[3] = new Point(x + SQUARE_LEN, y);
                    chessPoints[i,j].point = new Point(x, y);
                    Font fnt = new Font(FontFamily.GenericSansSerif, SQUARE_LEN / 2, FontStyle.Bold);
                    G.DrawPolygon(p, points);
                    if ((i + j) % 2 == 0)
                    {
                        G.FillPolygon(sb_white, points);
                        G.DrawString(chessPoints[i, j].move.ToString(), fnt , sb_black, chessPoints[i, j].point);
                    }
                    else
                    {
                        G.FillPolygon(sb_black, points);
                        G.DrawString(chessPoints[i, j].move.ToString(), fnt, sb_white, chessPoints[i, j].point);
                    }

                    x += SQUARE_LEN;
                }
                
                x = 0;
                y += SQUARE_LEN;
            }
        }
    }
  
    public static class ArrayExtensions
    {
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
