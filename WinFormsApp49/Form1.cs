namespace WinFormsApp49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "JowinBenitez" && textBox2.Text == "1111")
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();

            }
            else
            {
                MessageBox.Show("Your Password or Username is Incorrect");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}