namespace therad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(400, 400);
        }

        private void botton1_Click(object sender, EventArgs e)
        {
            //while (true)
            {
                ((Button)sender).Text = ((Button)sender).Text + "X";
                //Thread.Sleep(1000);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            botton1_Click(btn1, e);    
        }
    }
}
