namespace wfaSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += All_Click;
            button2.Click += All_Click;
            button3.Click += All_Click;
            checkBox1.Click += All_Click;
            label1.Click += All_Click;
            this.Click += All_Click;
        }                                   

       
        private void All_Click(object? sender, EventArgs e)
        {
            //MessageBox.Show(button1.Text);

            //Button button = (Button)sender;
            //MessageBox.Show(button.Text);

            //if (sender is Button)
            //    MessageBox.Show(((Button)sender).Text);
            //if (sender is Label)
            //    MessageBox.Show(((Label)sender).Text);
            //if (sender is Control)
            //    MessageBox.Show(((Control)sender).Text);

            if (sender is Control v)
                MessageBox.Show(v.Text);
        }
    }
}
