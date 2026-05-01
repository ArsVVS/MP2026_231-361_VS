using libCore;

namespace wfaGameCounter
{
    public partial class Form1 : Form
    {
        private readonly Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            game.ChangeQuestion += () => laQuestion.Text = game.QuestionLine;
            game.ChangeStat += Game_ChangeStat;
            game.Restart();

            buYes.Click += (s, e) => game.Answer(true);
            buNo.Click += (s, e) => game.Answer(false);
        }

        private void Game_ChangeStat()
        {
            laCountCorrect.Text = $"Верно = {game.CountCorrect}";
            laCountIncorrect.Text = $"Неверно = {game.CountInorrect}";
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
    }
}
