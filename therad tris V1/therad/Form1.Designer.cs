namespace therad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn1 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Ravie", 13F, FontStyle.Bold | FontStyle.Italic);
            btn1.ForeColor = Color.Red;
            btn1.Location = new Point(50, 50);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += botton1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Ravie", 48F, FontStyle.Bold | FontStyle.Italic);
            btn2.ForeColor = Color.Red;
            btn2.Location = new Point(150, 50);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 1;
            btn2.TextAlign = ContentAlignment.MiddleRight;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += botton1_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Ravie", 48F, FontStyle.Bold | FontStyle.Italic);
            btn4.ForeColor = Color.Red;
            btn4.Location = new Point(50, 150);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 2;
            btn4.TextAlign = ContentAlignment.MiddleRight;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += botton1_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Ravie", 48F, FontStyle.Bold | FontStyle.Italic);
            btn3.ForeColor = Color.Red;
            btn3.Location = new Point(250, 50);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 3;
            btn3.TextAlign = ContentAlignment.MiddleRight;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += botton1_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Ravie", 48F, FontStyle.Bold | FontStyle.Italic);
            btn7.ForeColor = Color.Red;
            btn7.Location = new Point(50, 250);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 4;
            btn7.TextAlign = ContentAlignment.MiddleRight;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += botton1_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Ravie", 48F, FontStyle.Bold | FontStyle.Italic);
            btn6.ForeColor = Color.Red;
            btn6.Location = new Point(250, 150);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 5;
            btn6.TextAlign = ContentAlignment.MiddleRight;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += botton1_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Ravie", 48F, FontStyle.Bold | FontStyle.Italic);
            btn5.ForeColor = Color.Red;
            btn5.Location = new Point(150, 150);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 6;
            btn5.TextAlign = ContentAlignment.MiddleRight;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += botton1_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Ravie", 48F, FontStyle.Bold | FontStyle.Italic);
            btn9.ForeColor = Color.Red;
            btn9.Location = new Point(250, 250);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 7;
            btn9.TextAlign = ContentAlignment.MiddleRight;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += botton1_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Ravie", 48F, FontStyle.Bold | FontStyle.Italic);
            btn8.ForeColor = Color.Red;
            btn8.Location = new Point(150, 250);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 8;
            btn8.TextAlign = ContentAlignment.MiddleRight;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += botton1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 450);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn4;
        private Button btn3;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn9;
        private Button btn8;
        private System.Windows.Forms.Timer timer1;
    }
}
