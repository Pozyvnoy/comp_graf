namespace Лаба_1_комп_графика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 1);
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawRectangle(myPen, 0, 0, pictureBox1.Size.Width - 1,pictureBox1.Size.Height - 1);
            g.Dispose();
        }
    }
}