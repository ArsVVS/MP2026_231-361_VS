namespace wfaPaint
{
    public partial class Form1 : Form
    {
        private enum MyDrawMode
        {
            Pencil,
            Line,
            Ellipse,
            Rectangle,
            Arrow,
            Select,
            Circle,
            Square,
            Triangle
        }
        
        private Bitmap b;
        private Graphics g;
        private MyDrawMode myDrawMode = MyDrawMode.Pencil;
        private Point startLocation;
        private Bitmap bb;
        private Pen myPen;
        private Rectangle selectionRect;
        private bool isSelecting = false;
        private Bitmap selectedImage;
        private bool isDragging = false;
        private Point dragOffset;
        private bool isFirstDrag = true;
        private bool isPasting = false;
        private bool isPreview = false;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

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

            // при смене инструмента сбрасываем выделение
            buModePencil.Click += (s, e) => { myDrawMode = MyDrawMode.Pencil; ClearSelection(); };
            buModeLine.Click += (s, e) => { myDrawMode = MyDrawMode.Line; ClearSelection(); };
            buModeEllipse.Click += (s, e) => { myDrawMode = MyDrawMode.Ellipse; ClearSelection(); };
            buModeRectangle.Click += (s, e) => { myDrawMode = MyDrawMode.Rectangle; ClearSelection(); };
            buModeArrow.Click += (s, e) => { myDrawMode = MyDrawMode.Arrow; ClearSelection(); };
            buModeCircle.Click += (s, e) => { myDrawMode = MyDrawMode.Circle; ClearSelection(); };
            buModeSquare.Click += (s, e) => { myDrawMode = MyDrawMode.Square; ClearSelection(); };
            buModeTriangle.Click += (s, e) => { myDrawMode = MyDrawMode.Triangle; ClearSelection(); };

            buSelect.Click += (s, e) => myDrawMode = MyDrawMode.Select;

            pxImage.MouseDown += PxImage_MouseDown;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseUp += PxImage_MouseUp;

            pxImage.Paint += (s, e) =>
            {
                e.Graphics.DrawImage(b, 0, 0);

                if (selectedImage != null && isPreview)
                {
                    e.Graphics.DrawImage(selectedImage, selectionRect);
                }

                // рамка
                if (myDrawMode == MyDrawMode.Select &&
                    selectionRect.Width > 0 &&
                    selectionRect.Height > 0)
                {
                    using (Pen p = new Pen(Color.Blue))
                    {
                        p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        e.Graphics.DrawRectangle(p, selectionRect);
                    }
                }
            };

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
            // Если тащили — один раз фиксируем в основной bitmap
            if (isDragging && selectedImage != null)
            {
                using (Graphics g2 = Graphics.FromImage(b))
                {
                    g2.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;

                    g2.DrawImage(selectedImage, selectionRect);
                }

                // обновляем backup
                bb = (Bitmap)b.Clone();
                isPreview = false;

                // убираем временный слой — иначе будут дубли
                selectedImage = null;
            }

            isDragging = false;
            isPasting = false;

            // Если именно выделяли — создаём selectedImage
            if (isSelecting)
            {
                if (selectionRect.Width > 0 && selectionRect.Height > 0)
                {
                    selectedImage = new Bitmap(selectionRect.Width, selectionRect.Height);

                    using (Graphics g2 = Graphics.FromImage(selectedImage))
                    {
                        g2.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;

                        g2.DrawImage(b,
                            new Rectangle(0, 0, selectionRect.Width, selectionRect.Height),
                            selectionRect,
                            GraphicsUnit.Pixel);
                    }
                }

                isSelecting = false;
            }

            pxImage.Invalidate();
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {

                selectionRect.X = e.X - dragOffset.X;
                selectionRect.Y = e.Y - dragOffset.Y;


                pxImage.Invalidate();
                return;
            }

            if (isSelecting)
            {

                selectionRect = new Rectangle(
                    Math.Min(startLocation.X, e.Location.X),
                    Math.Min(startLocation.Y, e.Location.Y),
                    Math.Abs(e.Location.X - startLocation.X),
                    Math.Abs(e.Location.Y - startLocation.Y)
                );

                pxImage.Invalidate();
                return;
            }

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
                        g.DrawRectangle(myPen,
                        Math.Min(startLocation.X, e.Location.X),
                        Math.Min(startLocation.Y, e.Location.Y),
                        Math.Abs(e.Location.X - startLocation.X),
                        Math.Abs(e.Location.Y - startLocation.Y));

                        break;
                    case MyDrawMode.Arrow:
                        RestoreBitmap();
                        DrawArrow(g, startLocation, e.Location);
                        break;
                    case MyDrawMode.Circle:
                        {

                        RestoreBitmap();

                        int dx = e.Location.X - startLocation.X;
                        int dy = e.Location.Y - startLocation.Y;

                        int size = Math.Max(Math.Abs(dx), Math.Abs(dy));

                        int x = dx < 0 ? startLocation.X - size : startLocation.X;
                        int y = dy < 0 ? startLocation.Y - size : startLocation.Y;

                        g.DrawEllipse(myPen, x, y, size, size);

                        break;
                        } 
                    case MyDrawMode.Square:
                        {

                        RestoreBitmap();

                        int dx = e.Location.X - startLocation.X;
                        int dy = e.Location.Y - startLocation.Y;

                        int side = Math.Max(Math.Abs(dx), Math.Abs(dy));

                        int x = dx < 0 ? startLocation.X - side : startLocation.X;
                        int y = dy < 0 ? startLocation.Y - side : startLocation.Y;

                        g.DrawRectangle(myPen, x, y, side, side);

                        break;
                        }
                        
                    case MyDrawMode.Triangle:
                        RestoreBitmap();

                        Point p1 = new Point(startLocation.X, e.Location.Y);
                        Point p2 = new Point(e.Location.X, e.Location.Y);
                        Point p3 = new Point((startLocation.X + e.Location.X) / 2, startLocation.Y);

                        g.DrawPolygon(myPen, new Point[] { p1, p2, p3 });

                        break;
                    default:
                        break;
                }

                pxImage.Invalidate();
            }
        }

        private void RestoreBitmap()
        {
            if (bb == null) return;

            g.Dispose();
            b = (Bitmap)bb.Clone();
            g = Graphics.FromImage(b);
        }

        private void PxImage_MouseDown(object? sender, MouseEventArgs e)
        {
            startLocation = e.Location;

            if (myDrawMode == MyDrawMode.Select &&
            selectedImage != null &&
            !selectionRect.Contains(e.Location))
            {
                // сначала фиксируем
                using (Graphics g2 = Graphics.FromImage(b))
                {
                    g2.DrawImage(selectedImage, selectionRect);
                }

                bb = (Bitmap)b.Clone();

                ClearSelection();
                return;
            }

            if (myDrawMode == MyDrawMode.Select)
            {
                // если клик внутри выделения то начинаем перемещение
                if (selectionRect.Contains(e.Location))
                {
                    isDragging = true;
                    isPreview = true;

                    dragOffset = new Point(
                        e.X - selectionRect.X,
                        e.Y - selectionRect.Y);

                    // вырезаем один раз
                    if (isFirstDrag && !isPasting)
                    {
                        using (Graphics g2 = Graphics.FromImage(b))
                        {
                            g2.FillRectangle(new SolidBrush(pxImage.BackColor), selectionRect);
                        }

                        bb = (Bitmap)b.Clone();
                        isFirstDrag = false;
                    }
                }
                else
                {
                    // начинаем новое выделение
                    isSelecting = true;
                    bb = (Bitmap)b.Clone();

                    isFirstDrag = true;
                }
            }
            else
            {
                // обычное рисование
                bb = (Bitmap)b.Clone();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DrawArrow(Graphics g, Point p1, Point p2)
        {
            g.DrawLine(myPen, p1, p2);

            var angle = Math.Atan2(p1.Y - p2.Y, p1.X - p2.X);
            int size = 10;

            Point p3 = new Point(
                (int)(p2.X + size * Math.Cos(angle + Math.PI / 6)),
                (int)(p2.Y + size * Math.Sin(angle + Math.PI / 6)));

            Point p4 = new Point(
                (int)(p2.X + size * Math.Cos(angle - Math.PI / 6)),
                (int)(p2.Y + size * Math.Sin(angle - Math.PI / 6)));

            g.DrawLine(myPen, p2, p3);
            g.DrawLine(myPen, p2, p4);
        }

   
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // DELETE удалить выделение
            if (e.KeyCode == Keys.Delete && selectedImage != null)
            {
                using (Graphics g2 = Graphics.FromImage(b))
                {
                    g2.FillRectangle(Brushes.White, selectionRect);
                }

                ClearSelection();
                pxImage.Invalidate();
            }

            // CTRL + C копировать
            if (e.Control && e.KeyCode == Keys.C && selectedImage != null)
            {
                Clipboard.SetImage(selectedImage);
            }

            // CTRL + V вставить
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsImage())
                {
                    Image img = Clipboard.GetImage();

                    if (img != null)
                    {
                        Bitmap tmp = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                        using (Graphics g2 = Graphics.FromImage(tmp))
                        {
                            g2.Clear(Color.White); // ЖЁСТКО белый
                            g2.DrawImage(img, 0, 0);
                        }

                        selectedImage = tmp;

                        selectionRect = new Rectangle(
                            50, 50,
                            selectedImage.Width,
                            selectedImage.Height);

                        isFirstDrag = true;
                        isPreview = true;
                        isPasting = true;
                        pxImage.Invalidate();
                    }
                }
            }
        }

        private void ClearSelection()
        {
            selectionRect = Rectangle.Empty;
            selectedImage = null;
            isSelecting = false;
            isDragging = false;
            isPreview = false;

            pxImage.Invalidate();
        }

    }
}
