
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MusicPlayerTut
{
    public partial class DrawFrom : Form
    {
        private SaveFileDialog sfd;
        private OpenFileDialog ofd;

        int x = -1;
        int y = -1;
        bool move = false;

        Pen pen;
        Bitmap bmp = new Bitmap(1920, 1080);
        Graphics graph;
        Image OpenedFile;

        public DrawFrom()
        {
            InitializeComponent();
            graph = boardPB.CreateGraphics();
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = LineCap.Round;
            sfd = new SaveFileDialog();

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; i < bmp.Height; i++)
                {
                    bmp.SetPixel(i, j, Color.White);
                }
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move && x != -1 && y != -1)
            {
                graph = Graphics.FromImage(bmp);
                graph.DrawLine(pen, new Point(x, y), e.Location);

                x = e.X;
                y = e.Y;
                boardPB.Image = bmp;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            x = -1;
            y = -1;
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



        private void colorPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                colorPick.BackColor = colorPicker.Color;
                PictureBox p = (PictureBox)sender;
                pen.Color = p.BackColor;
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            sfd.Filter = "Jpeg image|*.jpeg|Png image|*.png|bitmap Image *.bmp|";
            sfd.Title = "Save your drawing";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                FileStream fs = (FileStream)sfd.OpenFile();
                switch (sfd.FilterIndex)
                {
                    case 1:
                        this.boardPB.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.boardPB.Image.Save(fs, ImageFormat.Png);
                        break;
                    case 3:
                        this.boardPB.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    default:
                        this.boardPB.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();

            }


        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                OpenedFile = Image.FromFile(ofd.FileName);
                boardPB.Image = OpenedFile;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.graph.Clear(Color.White);
        }
    }
}
