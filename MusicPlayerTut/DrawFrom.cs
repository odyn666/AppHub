
using System.Drawing.Drawing2D;




namespace MusicPlayerTut
{
    public partial class DrawFrom : Form
    {
        Graphics graph;
        int x = -1;
        int y = -1;
        bool move = false;
        Pen pen;
        public DrawFrom()
        {
            InitializeComponent();
            graph = panel2.CreateGraphics();
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = LineCap.Round;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;

        }
        private void colorPick_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                colorPick.BackColor = colorPicker.Color;
                PictureBox p = (PictureBox)sender;
                pen.Color = p.BackColor;
            }
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move && x != -1 && y != -1)
            {
                graph.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            x = -1;
            y = -1;
        }

    }
}
