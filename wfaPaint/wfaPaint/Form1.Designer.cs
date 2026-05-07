namespace wfaPaint
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
            panel1 = new Panel();
            buSelect = new Button();
            buModeArrow = new Button();
            buCopyToClipboard = new Button();
            buLoadFromFile = new Button();
            buImageSaveToFile = new Button();
            buImageClear = new Button();
            buModeRectangle = new Button();
            buModeEllipse = new Button();
            buModeLine = new Button();
            buModePencil = new Button();
            trPenWidth = new TrackBar();
            paColor5 = new Panel();
            paColor4 = new Panel();
            paColor3 = new Panel();
            paColor2 = new Panel();
            paColor1 = new Panel();
            pxImage = new PictureBox();
            buModeSquare = new Button();
            buModeCircle = new Button();
            buModeTriangle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trPenWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buModeTriangle);
            panel1.Controls.Add(buModeCircle);
            panel1.Controls.Add(buModeSquare);
            panel1.Controls.Add(buSelect);
            panel1.Controls.Add(buModeArrow);
            panel1.Controls.Add(buCopyToClipboard);
            panel1.Controls.Add(buLoadFromFile);
            panel1.Controls.Add(buImageSaveToFile);
            panel1.Controls.Add(buImageClear);
            panel1.Controls.Add(buModeRectangle);
            panel1.Controls.Add(buModeEllipse);
            panel1.Controls.Add(buModeLine);
            panel1.Controls.Add(buModePencil);
            panel1.Controls.Add(trPenWidth);
            panel1.Controls.Add(paColor5);
            panel1.Controls.Add(paColor4);
            panel1.Controls.Add(paColor3);
            panel1.Controls.Add(paColor2);
            panel1.Controls.Add(paColor1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 491);
            panel1.TabIndex = 0;
            // 
            // buSelect
            // 
            buSelect.Location = new Point(200, 306);
            buSelect.Name = "buSelect";
            buSelect.Size = new Size(182, 41);
            buSelect.TabIndex = 15;
            buSelect.Text = "Select";
            buSelect.UseVisualStyleBackColor = true;
            // 
            // buModeArrow
            // 
            buModeArrow.Location = new Point(200, 142);
            buModeArrow.Name = "buModeArrow";
            buModeArrow.Size = new Size(182, 41);
            buModeArrow.TabIndex = 14;
            buModeArrow.Text = "Arrow";
            buModeArrow.UseVisualStyleBackColor = true;
            // 
            // buCopyToClipboard
            // 
            buCopyToClipboard.Location = new Point(12, 444);
            buCopyToClipboard.Name = "buCopyToClipboard";
            buCopyToClipboard.Size = new Size(182, 41);
            buCopyToClipboard.TabIndex = 13;
            buCopyToClipboard.Text = "Copy to clipboard";
            buCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // buLoadFromFile
            // 
            buLoadFromFile.Location = new Point(10, 397);
            buLoadFromFile.Name = "buLoadFromFile";
            buLoadFromFile.Size = new Size(182, 41);
            buLoadFromFile.TabIndex = 12;
            buLoadFromFile.Text = "Load from file";
            buLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // buImageSaveToFile
            // 
            buImageSaveToFile.Location = new Point(10, 353);
            buImageSaveToFile.Name = "buImageSaveToFile";
            buImageSaveToFile.Size = new Size(182, 41);
            buImageSaveToFile.TabIndex = 11;
            buImageSaveToFile.Text = "Save to file";
            buImageSaveToFile.UseVisualStyleBackColor = true;
            // 
            // buImageClear
            // 
            buImageClear.Location = new Point(10, 306);
            buImageClear.Name = "buImageClear";
            buImageClear.Size = new Size(182, 41);
            buImageClear.TabIndex = 10;
            buImageClear.Text = "Clear Image";
            buImageClear.UseVisualStyleBackColor = true;
            // 
            // buModeRectangle
            // 
            buModeRectangle.Location = new Point(200, 95);
            buModeRectangle.Name = "buModeRectangle";
            buModeRectangle.Size = new Size(182, 41);
            buModeRectangle.TabIndex = 9;
            buModeRectangle.Text = "Rectangle";
            buModeRectangle.UseVisualStyleBackColor = true;
            // 
            // buModeEllipse
            // 
            buModeEllipse.Location = new Point(12, 189);
            buModeEllipse.Name = "buModeEllipse";
            buModeEllipse.Size = new Size(182, 41);
            buModeEllipse.TabIndex = 8;
            buModeEllipse.Text = "Ellipse";
            buModeEllipse.UseVisualStyleBackColor = true;
            buModeEllipse.Click += button3_Click;
            // 
            // buModeLine
            // 
            buModeLine.Location = new Point(12, 142);
            buModeLine.Name = "buModeLine";
            buModeLine.Size = new Size(182, 41);
            buModeLine.TabIndex = 7;
            buModeLine.Text = "Line";
            buModeLine.UseVisualStyleBackColor = true;
            // 
            // buModePencil
            // 
            buModePencil.Location = new Point(12, 95);
            buModePencil.Name = "buModePencil";
            buModePencil.Size = new Size(182, 41);
            buModePencil.TabIndex = 6;
            buModePencil.Text = "Pencil";
            buModePencil.UseVisualStyleBackColor = true;
            // 
            // trPenWidth
            // 
            trPenWidth.Location = new Point(10, 58);
            trPenWidth.Name = "trPenWidth";
            trPenWidth.Size = new Size(184, 50);
            trPenWidth.TabIndex = 5;
            // 
            // paColor5
            // 
            paColor5.BackColor = Color.Black;
            paColor5.Location = new Point(162, 12);
            paColor5.Name = "paColor5";
            paColor5.Size = new Size(32, 31);
            paColor5.TabIndex = 4;
            // 
            // paColor4
            // 
            paColor4.BackColor = Color.Yellow;
            paColor4.Location = new Point(124, 12);
            paColor4.Name = "paColor4";
            paColor4.Size = new Size(32, 31);
            paColor4.TabIndex = 3;
            // 
            // paColor3
            // 
            paColor3.BackColor = Color.Fuchsia;
            paColor3.Location = new Point(86, 12);
            paColor3.Name = "paColor3";
            paColor3.Size = new Size(32, 31);
            paColor3.TabIndex = 2;
            // 
            // paColor2
            // 
            paColor2.BackColor = Color.Lime;
            paColor2.Location = new Point(48, 12);
            paColor2.Name = "paColor2";
            paColor2.Size = new Size(32, 31);
            paColor2.TabIndex = 1;
            // 
            // paColor1
            // 
            paColor1.BackColor = Color.FromArgb(192, 0, 0);
            paColor1.Location = new Point(10, 12);
            paColor1.Name = "paColor1";
            paColor1.Size = new Size(32, 31);
            paColor1.TabIndex = 0;
            // 
            // pxImage
            // 
            pxImage.Dock = DockStyle.Fill;
            pxImage.Location = new Point(394, 0);
            pxImage.Name = "pxImage";
            pxImage.Size = new Size(502, 491);
            pxImage.TabIndex = 1;
            pxImage.TabStop = false;
            // 
            // buModeSquare
            // 
            buModeSquare.Location = new Point(12, 236);
            buModeSquare.Name = "buModeSquare";
            buModeSquare.Size = new Size(182, 41);
            buModeSquare.TabIndex = 16;
            buModeSquare.Text = "Square";
            buModeSquare.UseVisualStyleBackColor = true;
            // 
            // buModeCircle
            // 
            buModeCircle.Location = new Point(200, 189);
            buModeCircle.Name = "buModeCircle";
            buModeCircle.Size = new Size(182, 41);
            buModeCircle.TabIndex = 17;
            buModeCircle.Text = "Circle";
            buModeCircle.UseVisualStyleBackColor = true;
            // 
            // buModeTriangle
            // 
            buModeTriangle.Location = new Point(200, 236);
            buModeTriangle.Name = "buModeTriangle";
            buModeTriangle.Size = new Size(182, 41);
            buModeTriangle.TabIndex = 18;
            buModeTriangle.Text = "Triangle";
            buModeTriangle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 491);
            Controls.Add(pxImage);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "wfaPaint";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trPenWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TrackBar trPenWidth;
        private Panel paColor5;
        private Panel paColor4;
        private Panel paColor3;
        private Panel paColor2;
        private Panel paColor1;
        private PictureBox pxImage;
        private Button buModeRectangle;
        private Button buModeEllipse;
        private Button buModeLine;
        private Button buModePencil;
        private Button buLoadFromFile;
        private Button buImageSaveToFile;
        private Button buImageClear;
        private Button buCopyToClipboard;
        private Button buModeArrow;
        private Button buSelect;
        private Button buModeTriangle;
        private Button buModeCircle;
        private Button buModeSquare;
    }
}
