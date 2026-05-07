using libCore;

namespace wfaGameCounter
{
    public partial class Form1 : Form
    {
        private readonly Game game;
        private int timeLeft = 10;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            game.ChangeQuestion += StartTimer;
            cbDifficulty.SelectedIndexChanged += CbDifficulty_SelectedIndexChanged;
            cbDifficulty.SelectedIndex = 0;
            game.ChangeQuestion += () => laQuestion.Text = game.QuestionLine;
            game.ChangeStat += Game_ChangeStat;
            game.Restart();

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            buYes.Click += (s, e) => game.Answer(true);
            buNo.Click += (s, e) => game.Answer(false);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            laTimer.Text = $"Время: {timeLeft}";

            if (timeLeft <= 0)
            {
                timer1.Stop();
                game.Answer(false); // считаем как ошибку
                StartTimer();
            }
        }

        private void CbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDifficulty.SelectedIndex)
            {
                case 0:
                    game.MaxNumber = 20;
                    break;

                case 1:
                    game.MaxNumber = 40;
                    break;

                case 2:
                    game.MaxNumber = 60;
                    break;
            }
        }

        private void StartTimer()
        {
            timeLeft = 10;
            laTimer.Text = $"Время: {timeLeft}";
            timer1.Start();
        }

        private void Game_ChangeStat()
        {
            laCountCorrect.Text = $"Верно = {game.CountCorrect}";
            laCountIncorrect.Text = $"Неверно = {game.CountInorrect}";
            laQuestionNumber.Text = $"Вопрос: {game.QuestionNumber}";
            laCoins.Text = $"Монеты: {game.Coins}";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
