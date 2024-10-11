namespace tris
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            labelTurno = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(71, 83);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(143, 167);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(286, 83);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(143, 167);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(500, 83);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(143, 167);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(71, 333);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(143, 167);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(286, 333);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(143, 167);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(500, 333);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(143, 167);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(71, 583);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(143, 167);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(286, 583);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "button8";
            button8.Size = new Size(143, 167);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(500, 583);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "button9";
            button9.Size = new Size(143, 167);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 815);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 40);
            label1.TabIndex = 9;
            label1.Text = "E' il turno di ";
            // 
            // labelTurno
            // 
            labelTurno.AutoSize = true;
            labelTurno.Cursor = Cursors.IBeam;
            labelTurno.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTurno.Location = new Point(264, 803);
            labelTurno.Margin = new Padding(4, 0, 4, 0);
            labelTurno.Name = "labelTurno";
            labelTurno.Size = new Size(44, 48);
            labelTurno.TabIndex = 10;
            labelTurno.Text = "X";
            labelTurno.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 985);
            Controls.Add(labelTurno);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            AutoSizeChanged += timer1_Tick;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label labelTurno;
        private System.Windows.Forms.Timer timer1;
    }
}
