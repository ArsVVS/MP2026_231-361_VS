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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            laCountIncorrect = new Label();
            laCountCorrect = new Label();
            label5 = new Label();
            laQuestion = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buNo = new Button();
            buYes = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            laTimer = new Label();
            laQuestionNumber = new Label();
            cbDifficulty = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            laCoins = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(862, 86);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // laCountIncorrect
            // 
            laCountIncorrect.AutoSize = true;
            laCountIncorrect.BackColor = Color.FromArgb(255, 192, 192);
            laCountIncorrect.Dock = DockStyle.Fill;
            laCountIncorrect.Location = new Point(434, 0);
            laCountIncorrect.Name = "laCountIncorrect";
            laCountIncorrect.Size = new Size(425, 86);
            laCountIncorrect.TabIndex = 1;
            laCountIncorrect.Text = "Неверно = 0";
            laCountIncorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laCountCorrect
            // 
            laCountCorrect.AutoSize = true;
            laCountCorrect.BackColor = Color.FromArgb(192, 255, 192);
            laCountCorrect.Dock = DockStyle.Fill;
            laCountCorrect.Location = new Point(3, 0);
            laCountCorrect.Name = "laCountCorrect";
            laCountCorrect.Size = new Size(425, 86);
            laCountCorrect.TabIndex = 0;
            laCountCorrect.Text = "Верно = 0";
            laCountCorrect.TextAlign = ContentAlignment.MiddleCenter;
            laCountCorrect.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 20.2909088F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 73);
            label5.Name = "label5";
            label5.Size = new Size(856, 74);
            label5.TabIndex = 2;
            label5.Text = "Верно?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // laQuestion
            // 
            laQuestion.AutoSize = true;
            laQuestion.Dock = DockStyle.Fill;
            laQuestion.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold, GraphicsUnit.Point, 204);
            laQuestion.Location = new Point(3, 0);
            laQuestion.Name = "laQuestion";
            laQuestion.Size = new Size(856, 73);
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
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(862, 147);
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
            tableLayoutPanel2.Location = new Point(0, 331);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(862, 117);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // buNo
            // 
            buNo.BackColor = SystemColors.ControlLight;
            buNo.Dock = DockStyle.Fill;
            buNo.Font = new Font("Segoe UI", 22.2545452F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buNo.ForeColor = Color.Maroon;
            buNo.Location = new Point(434, 3);
            buNo.Name = "buNo";
            buNo.Size = new Size(425, 111);
            buNo.TabIndex = 1;
            buNo.Text = "Нет";
            buNo.UseVisualStyleBackColor = false;
            // 
            // buYes
            // 
            buYes.BackColor = SystemColors.ControlLight;
            buYes.Dock = DockStyle.Fill;
            buYes.Font = new Font("Segoe UI", 22.2545452F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buYes.ForeColor = Color.Green;
            buYes.Location = new Point(3, 3);
            buYes.Name = "buYes";
            buYes.Size = new Size(425, 111);
            buYes.TabIndex = 0;
            buYes.Text = "Да";
            buYes.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.1428566F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.8571434F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tableLayoutPanel4.Controls.Add(laQuestionNumber, 1, 0);
            tableLayoutPanel4.Controls.Add(cbDifficulty, 0, 0);
            tableLayoutPanel4.Controls.Add(laTimer, 3, 0);
            tableLayoutPanel4.Controls.Add(laCoins, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 233);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(862, 96);
            tableLayoutPanel4.TabIndex = 6;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // laTimer
            // 
            laTimer.AutoSize = true;
            laTimer.Dock = DockStyle.Fill;
            laTimer.Font = new Font("Segoe UI", 18.3272724F, FontStyle.Regular, GraphicsUnit.Point, 204);
            laTimer.Location = new Point(669, 0);
            laTimer.Name = "laTimer";
            laTimer.Size = new Size(190, 96);
            laTimer.TabIndex = 1;
            laTimer.Text = "label1";
            laTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laQuestionNumber
            // 
            laQuestionNumber.AutoSize = true;
            laQuestionNumber.Dock = DockStyle.Fill;
            laQuestionNumber.Font = new Font("Segoe UI", 18.3272724F, FontStyle.Regular, GraphicsUnit.Point, 204);
            laQuestionNumber.Location = new Point(230, 0);
            laQuestionNumber.Name = "laQuestionNumber";
            laQuestionNumber.Size = new Size(203, 96);
            laQuestionNumber.TabIndex = 0;
            laQuestionNumber.Text = "Вопрос: 1";
            laQuestionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbDifficulty
            // 
            cbDifficulty.Dock = DockStyle.Top;
            cbDifficulty.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbDifficulty.FormattingEnabled = true;
            cbDifficulty.Items.AddRange(new object[] { "Легкий", "Средний", "Сложный" });
            cbDifficulty.Location = new Point(3, 3);
            cbDifficulty.Name = "cbDifficulty";
            cbDifficulty.Size = new Size(221, 33);
            cbDifficulty.TabIndex = 0;
            cbDifficulty.Text = "Уровни сложности";
            // 
            // laCoins
            // 
            laCoins.AutoSize = true;
            laCoins.Dock = DockStyle.Fill;
            laCoins.Font = new Font("Segoe UI", 18.3272724F, FontStyle.Regular, GraphicsUnit.Point, 204);
            laCoins.Location = new Point(439, 0);
            laCoins.Name = "laCoins";
            laCoins.Size = new Size(224, 96);
            laCoins.TabIndex = 2;
            laCoins.Text = "Монеты: 0";
            laCoins.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 448);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(400, 400);
            Name = "Form1";
            Text = "Игра 'Устный счет'";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel4;
        private Label laQuestionNumber;
        private Label laTimer;
        private System.Windows.Forms.Timer timer1;
        private ComboBox cbDifficulty;
        private Label laCoins;
    }
}
