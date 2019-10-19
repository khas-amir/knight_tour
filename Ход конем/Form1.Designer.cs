namespace Ход_конем
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.n_label = new System.Windows.Forms.Label();
            this.m_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.m_textBox = new System.Windows.Forms.TextBox();
            this.x_textBox = new System.Windows.Forms.TextBox();
            this.y_textBox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.chess_board = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // n_label
            // 
            this.n_label.AutoSize = true;
            this.n_label.Location = new System.Drawing.Point(637, 41);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(60, 13);
            this.n_label.TabIndex = 0;
            this.n_label.Text = "Введите N";
            this.n_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // m_label
            // 
            this.m_label.AutoSize = true;
            this.m_label.Location = new System.Drawing.Point(637, 74);
            this.m_label.Name = "m_label";
            this.m_label.Size = new System.Drawing.Size(61, 13);
            this.m_label.TabIndex = 1;
            this.m_label.Text = "Введите M";
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(487, 138);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(211, 13);
            this.x_label.TabIndex = 2;
            this.x_label.Text = "Введите координату X начала движения";
            this.x_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Location = new System.Drawing.Point(490, 178);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(211, 13);
            this.y_label.TabIndex = 3;
            this.y_label.Text = "Введите координату Y начала движения";
            // 
            // n_textBox
            // 
            this.n_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.n_textBox.Location = new System.Drawing.Point(757, 38);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(75, 20);
            this.n_textBox.TabIndex = 4;
            // 
            // m_textBox
            // 
            this.m_textBox.Location = new System.Drawing.Point(757, 71);
            this.m_textBox.Name = "m_textBox";
            this.m_textBox.Size = new System.Drawing.Size(75, 20);
            this.m_textBox.TabIndex = 5;
            // 
            // x_textBox
            // 
            this.x_textBox.Location = new System.Drawing.Point(757, 178);
            this.x_textBox.Name = "x_textBox";
            this.x_textBox.Size = new System.Drawing.Size(75, 20);
            this.x_textBox.TabIndex = 6;
            // 
            // y_textBox
            // 
            this.y_textBox.Location = new System.Drawing.Point(757, 138);
            this.y_textBox.Name = "y_textBox";
            this.y_textBox.Size = new System.Drawing.Size(75, 20);
            this.y_textBox.TabIndex = 7;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(739, 271);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(93, 26);
            this.start_button.TabIndex = 8;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // chess_board
            // 
            this.chess_board.Location = new System.Drawing.Point(24, 38);
            this.chess_board.Name = "chess_board";
            this.chess_board.Size = new System.Drawing.Size(460, 460);
            this.chess_board.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 524);
            this.Controls.Add(this.chess_board);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.y_textBox);
            this.Controls.Add(this.x_textBox);
            this.Controls.Add(this.m_textBox);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.m_label);
            this.Controls.Add(this.n_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label n_label;
        private System.Windows.Forms.Label m_label;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.TextBox m_textBox;
        private System.Windows.Forms.TextBox x_textBox;
        private System.Windows.Forms.TextBox y_textBox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Panel chess_board;
    }
}

