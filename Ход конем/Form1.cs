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

        public struct ChessPoint
        {
            public Point point;
            public int move;
        }

        private ChessPoint[,] chess_points;

        private static int[,] directions = new int[,] { { 2, 1 },
                                                       { 1, 2 },
                                                       { -1, 2 },
                                                       { -2, 1 },
                                                       { -2, -1 },
                                                       { -1, -2 },
                                                       { 1, -2 },
                                                       { 2, -1 } };
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            int x = 0, y = 0;
            if (Int32.TryParse(n_textBox.Text, out n) &&
                Int32.TryParse(m_textBox.Text, out m) &&
                Int32.TryParse(x_textBox.Text, out x) &&
                Int32.TryParse(y_textBox.Text, out y) )
            {
                if (x > n || y > m || x <= 0 || y <= 0 )
                {
                    MessageBox.Show("Текущая позиция выходит за границу массива");
                } else
                {
                    init_chess_points(n, m, x, y);
                    Draw_board(chess_points, n, m);
                }
            } else
            {
                MessageBox.Show("Неправильные данные");
            }
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void init_chess_points(int row, int col, int currX, int currY)
        {
            chess_points = new ChessPoint[row, col];

            // Init array
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    chess_points[i, j].move = 0;
                }
            }
            chess_points[currX - 1, currY - 1].move = 1;
        }

        public void Draw_board(ChessPoint[,] chess_points, int row, int col)
        {
            Graphics G = chess_board.CreateGraphics();
            G.Clear(Color.White);
            Pen p = new Pen(Color.Black);
            SolidBrush sb_black = new SolidBrush(Color.Black);
            SolidBrush sb_white = new SolidBrush(Color.White);
            SolidBrush sb_square;
            SolidBrush sb_text;
            bool is_even;
            const int SQUARE_LEN = 50;
            
            int x = 0;
            int y = 0;
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Point[] points = new Point[4];
                    points[0] = new Point(x, y);
                    points[1] = new Point(x, y + SQUARE_LEN);
                    points[2] = new Point(x + SQUARE_LEN, y + SQUARE_LEN);
                    points[3] = new Point(x + SQUARE_LEN, y);
                    chess_points[i,j].point = new Point(x, y);
                    Font fnt = new Font(FontFamily.GenericSansSerif, SQUARE_LEN / 2, FontStyle.Bold);                    
                    G.DrawPolygon(p, points);
                    is_even = (i + j) % 2 == 0;
                    sb_square = is_even ? sb_white : sb_black;
                    sb_text = is_even ? sb_black : sb_white;
                    G.FillPolygon(sb_square, points);
                    G.DrawString(chess_points[i, j].move.ToString(), fnt , sb_text, chess_points[i, j].point);
                    x += SQUARE_LEN;
                }
                
                x = 0;
                y += SQUARE_LEN;
            }
        }
    }
}
