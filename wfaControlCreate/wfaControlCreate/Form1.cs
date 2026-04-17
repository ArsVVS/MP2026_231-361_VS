namespace wfaControlCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label x = new Label();
                x.Location = e.Location;
                x.Text = $"({x.Location.X}, {x.Location.Y})";
                x.BackColor = Color.LightCoral;
                this.Controls.Add(x);
            }
        }
    }
}
