namespace wfaPaint
{
    public partial class Form1 : Form
    {
        private enum MyDrawMode
        {
            Pencil,
            Line,
            Ellipse,
            Rectangle
        }
        
        private Bitmap b;
        private Graphics g;
        private MyDrawMode myDrawMode = MyDrawMode.Pencil;
        private Point startLocation;
        private Bitmap bb;
        private Pen myPen;

        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = Graphics.FromImage(b);

            myPen = new Pen(paColor1.BackColor, 10);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            paColor1.Click += (s, e) => myPen.Color = paColor1.BackColor;
            paColor2.Click += (s, e) => myPen.Color = paColor2.BackColor;
            paColor3.Click += (s, e) => myPen.Color = paColor3.BackColor;
            paColor4.Click += (s, e) => myPen.Color = paColor4.BackColor;
            paColor5.Click += (s, e) => myPen.Color = paColor5.BackColor;

            trPenWidth.Minimum = 1;
            trPenWidth.Maximum = 20;
            trPenWidth.Value = Convert.ToInt32(myPen.Width);
            trPenWidth.ValueChanged += (s, e) => myPen.Width = trPenWidth.Value;

            buModePencil.Click += (s, e) => myDrawMode = MyDrawMode.Pencil;
            buModeLine.Click += (s, e) => myDrawMode = MyDrawMode.Line;
            buModeEllipse.Click += (s, e) => myDrawMode = MyDrawMode.Ellipse;
            buModeRectangle.Click += (s, e) => myDrawMode = MyDrawMode.Rectangle;

            pxImage.MouseDown += PxImage_MouseDown;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseUp += PxImage_MouseUp;
            pxImage.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);

            buImageClear.Click += BuImageClear_Click;
            buImageSaveToFile.Click += BuImageSaveToFile_Click;
            buLoadFromFile.Click += BuLoadFromFile_Click;
            buCopyToClipboard.Click += (s, e) => Clipboard.SetImage(b);
        }

        private void BuLoadFromFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "PNG Image Files(*.PNG)|*.PNG";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                g.Clear(DefaultBackColor);
                g.DrawImage(Bitmap.FromFile(dialog.FileName), 0, 0);
                pxImage.Invalidate();
            }
        }

        private void BuImageSaveToFile_Click(object? sender, EventArgs e)
        {
            SaveFileDialog dialog = new();
            dialog.Filter = "PNG Image Files(*.PNG)|*.PNG";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                b.Save(dialog.FileName);
                //b.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void BuImageClear_Click(object? sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            pxImage.Invalidate();
        }

        private void PxImage_MouseUp(object? sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //g.DrawLine(myPen, startLocation, e.Location);
                //startLocation = e.Location;
                switch (myDrawMode)
                {
                    case MyDrawMode.Pencil:
                        g.DrawLine(myPen, startLocation, e.Location);
                        startLocation = e.Location;
                        break;
                    case MyDrawMode.Line:
                        RestoreBitmap();
                        g.DrawLine(myPen, startLocation, e.Location);
                        break;
                    case MyDrawMode.Ellipse:
                        RestoreBitmap();
                        g.DrawEllipse(myPen, 
                            startLocation.X, startLocation.Y, 
                            e.Location.X - startLocation.X, e.Location.Y - startLocation.Y);
                        break;
                    case MyDrawMode.Rectangle:
                        RestoreBitmap();
                        // Доработать с другими фигурами, также сделать чтобы выделить и перетаскивать отдельный кусок

                        break;
                    default:
                        break;
                }

                pxImage.Invalidate();
            }
        }

        private void RestoreBitmap()
        {
            g.Dispose();
            b = (Bitmap)bb.Clone();
            g = Graphics.FromImage(b);
        }

        private void PxImage_MouseDown(object? sender, MouseEventArgs e)
        {
            startLocation = e.Location;
            bb = (Bitmap)b.Clone();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
