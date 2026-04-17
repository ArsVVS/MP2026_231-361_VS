namespace wfaEventKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MessageBox.Show("Нажата клавиша Enter");
            switch (e.KeyCode)
            {
                case Keys.Left:
                    label1.Text = "Left";
                    break;
                case Keys.Up:
                    label1.Text = "Up";
                    break;
                case Keys.Right:
                    label1.Text = "Right";
                    break;
                case Keys.Down:
                    label1.Text = "Down";
                    break;
                case Keys.Space:
                    if (e.Shift)
                    {
                        label1.Text = "Shift + Space";
                    }
                    else
                    {
                        label1.Text = "Space";
                    }
                    break;
                case Keys.Z:
                    label1.Text = e.Shift ? "Shift + Z" : "Z";
                    break;
                default:
                    label1.Text = $"Другая клавиша = {e.KeyCode}";
                    break;
            }
        }
    }
}
