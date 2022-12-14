namespace WinFormsControlsExtendApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.BackColor = Color.Aqua;
            pictureBox1.Image = Image.FromFile("D:/61ljooq2jrqb.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //WebBrowser webBrowser = new();
            //this.Controls.Add(webBrowser);
            //webBrowser.Location = new Point(250, 100);
            //webBrowser.Size = new Size(300, 300);
            //webBrowser.Navigate("https://ya.ru");
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if(timerMove.Enabled)
                btnTimer.Text = "START";
            else
                btnTimer.Text = "STOP";
            timerMove.Enabled = !timerMove.Enabled;
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            btnMove.Location = new Point(btnMove.Location.X + 5, btnMove.Location.Y);
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            while(progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                Thread.Sleep(500);
            }
        }
    }
}