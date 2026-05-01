namespace wfaGameCounter
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
            tableLayoutPanel1 = new TableLayoutPanel();
            laCountIncorrect = new Label();
            laCountCorrect = new Label();
            label5 = new Label();
            laQuestion = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buNo = new Button();
            buYes = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(laCountIncorrect, 1, 0);
            tableLayoutPanel1.Controls.Add(laCountCorrect, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI", 20.2909088F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(742, 86);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label2
            // 
            laCountIncorrect.AutoSize = true;
            laCountIncorrect.BackColor = Color.FromArgb(255, 192, 192);
            laCountIncorrect.Dock = DockStyle.Fill;
            laCountIncorrect.Location = new Point(374, 0);
            laCountIncorrect.Name = "label2";
            laCountIncorrect.Size = new Size(365, 86);
            laCountIncorrect.TabIndex = 1;
            laCountIncorrect.Text = "Неверно = 0";
            laCountIncorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            laCountCorrect.AutoSize = true;
            laCountCorrect.BackColor = Color.FromArgb(192, 255, 192);
            laCountCorrect.Dock = DockStyle.Fill;
            laCountCorrect.Location = new Point(3, 0);
            laCountCorrect.Name = "label1";
            laCountCorrect.Size = new Size(365, 86);
            laCountCorrect.TabIndex = 0;
            laCountCorrect.Text = "Верно = 0";
            laCountCorrect.TextAlign = ContentAlignment.MiddleCenter;
            laCountCorrect.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 113);
            label5.Name = "label5";
            label5.Size = new Size(736, 114);
            label5.TabIndex = 2;
            label5.Text = "Верно?";
            label5.TextAlign = ContentAlignment.BottomCenter;
            label5.Click += label5_Click;
            // 
            // laQuestion
            // 
            laQuestion.AutoSize = true;
            laQuestion.Dock = DockStyle.Fill;
            laQuestion.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold, GraphicsUnit.Point, 204);
            laQuestion.Location = new Point(3, 0);
            laQuestion.Name = "laQuestion";
            laQuestion.Size = new Size(736, 113);
            laQuestion.TabIndex = 3;
            laQuestion.Text = "10 + 11 = 21";
            laQuestion.TextAlign = ContentAlignment.MiddleCenter;
            laQuestion.Click += label6_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(laQuestion, 0, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 86);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(742, 227);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buNo, 1, 0);
            tableLayoutPanel2.Controls.Add(buYes, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 319);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(742, 131);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // button2
            // 
            buNo.BackColor = SystemColors.ControlLight;
            buNo.Dock = DockStyle.Fill;
            buNo.Font = new Font("Segoe UI", 22.2545452F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buNo.ForeColor = Color.Maroon;
            buNo.Location = new Point(374, 3);
            buNo.Name = "button2";
            buNo.Size = new Size(365, 125);
            buNo.TabIndex = 1;
            buNo.Text = "Нет";
            buNo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            buYes.BackColor = SystemColors.ControlLight;
            buYes.Dock = DockStyle.Fill;
            buYes.Font = new Font("Segoe UI", 22.2545452F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buYes.ForeColor = Color.Green;
            buYes.Location = new Point(3, 3);
            buYes.Name = "button1";
            buYes.Size = new Size(365, 125);
            buYes.TabIndex = 0;
            buYes.Text = "Да";
            buYes.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(400, 400);
            Name = "Form1";
            Text = "Игра 'Устный счет'";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label laCountCorrect;
        private Label laCountIncorrect;
        private Label label5;
        private Label laQuestion;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buNo;
        private Button buYes;
    }
}
