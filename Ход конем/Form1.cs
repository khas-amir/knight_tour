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
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        const int SQUARE_LEN = 50;
        private static List<int[]> directions = new List<int[]>()
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
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Введите в текстовых полях числа от 1 до 8");
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        private  void  button1_Click(object sender, EventArgs e)
        {
            const int maxX = 8;
            const int maxY = 8;
            int n = 0; int m = 0;
            int x = 0; int y = 0;
            
            if (Int32.TryParse(n_textBox.Text, out n) &&
                Int32.TryParse(m_textBox.Text, out m) &&
                Int32.TryParse(x_textBox.Text, out x) &&
                Int32.TryParse(y_textBox.Text, out y) &&
                n < maxX && m < maxY)
            {

                if ( x <= n && y <= m && x > 0 && y > 0)
                {
                    
                    //this.Size = new Size(SQUARE_LEN * n + 400, SQUARE_LEN * m + 200);
                    KnightTour board = new KnightTour(n, m, x - 1, y - 1);

                    //await Task.Delay(1000);
                    foreach(int move in board.Board)
                    {
                        if (move == 0)
                        {
                            MessageBox.Show("Решений нет");
                            return;
                        }
                    }
                    draw_board(board.Board);
 
                } else
                {
                    MessageBox.Show("Текущая позиция вышла за границу массива");
                } 
            } else
            {
                MessageBox.Show("Неверные данные");
            }
        }
    
        public void draw_board(int[,] moveHorse)
        {
            
            Graphics G = chess_board.CreateGraphics();
            G.Clear(Color.White);
            Pen p = new Pen(Color.Black);
            SolidBrush sb_black = new SolidBrush(Color.Black);
            SolidBrush sb_white = new SolidBrush(Color.White);
            
            
            int x = 0;
            int y = 0;
            for (int i = 0; i < moveHorse.GetLength(0); i++)
            {
                for(int j = 0; j < moveHorse.GetLength(1); j++)
                {
                    Point[] points = new Point[4];
                    points[0] = new Point(x, y);
                    points[1] = new Point(x, y + SQUARE_LEN);
                    points[2] = new Point(x + SQUARE_LEN, y + SQUARE_LEN);
                    points[3] = new Point(x + SQUARE_LEN, y);
                    Font fnt = new Font(FontFamily.GenericSansSerif, SQUARE_LEN / 2, FontStyle.Bold);
                    G.DrawPolygon(p, points);
                    if ((i + j) % 2 == 0)
                    {
                        G.FillPolygon(sb_white, points);
                        G.DrawString(moveHorse[i, j].ToString(), fnt , sb_black, points[0]);
                    }
                    else
                    {
                        G.FillPolygon(sb_black, points);
                        G.DrawString(moveHorse[i, j].ToString(), fnt, sb_white, points[0]);
                    }

                    x += SQUARE_LEN;
                }
                
                x = 0;
                y += SQUARE_LEN;
            }
        }
        
    }

}
