using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp49
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
            listBox2.Items.Remove(textBox2.Text);
            listBox3.Items.Remove(textBox3.Text);
            listBox4.Items.Remove(textBox4.Text);
            System.Windows.Forms.MessageBox.Show("Item Deleted!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want to Exit", "Exit Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
