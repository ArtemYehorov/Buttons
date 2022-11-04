namespace Buttons
{
    public partial class Form1 : Form
    {
        Button [,] r = new Button[10,10];
        public Form1()
        {
            InitializeComponent();
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Random t = new Random();
                    r[y, x] = new Button();
                    r[y, x].Width = 50;
                    r[y, x].Height = 50;
                    r[y, x].Parent = this;
                    r[y, x].Text = " ";
                    r[y, x].Location = new Point(50 * x, 50 * y);
                    r[y, x].BackColor = Color.FromArgb(t.Next(0, 256), t.Next(0, 256), t.Next(0, 256));
                    r[y, x].MouseClick += r_MouseClick;
                }
            }
        }
        private void r_MouseClick(object sender, MouseEventArgs e)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (((Button)sender).Location.X == r[y,x].Location.X && ((Button)sender).Location.Y == r[y, x].Location.Y)
                    {
                        r[y,x].Dispose();
                    }
                }
            }
        }
    }
}