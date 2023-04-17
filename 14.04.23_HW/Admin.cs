using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._04._23_HW
{
    public partial class Admin : Form
    {
        public Form1 frm;
        List<string> temp = new List<string>();
        public Admin()
        {
            InitializeComponent();
            
        }
        public void Start(string[] arr)
        {
            temp = arr.ToList<string>();
            numericUpDown1.Maximum = temp.Count / 5;
            textBox1.Text = temp[((int)numericUpDown1.Value)-1];
            textBox2.Text = temp[((int)numericUpDown1.Value)];
            textBox3.Text = temp[((int)numericUpDown1.Value) + 1];
            textBox4.Text = temp[((int)numericUpDown1.Value) + 2];
            textBox5.Text = temp[((int)numericUpDown1.Value) + 3];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frm.lines = temp.ToArray();
            frm.Show();
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int pos = (((int)numericUpDown1.Value) - 1) * 5;
            textBox1.Text = temp[pos];
            textBox2.Text = temp[pos+1];
            textBox3.Text = temp[pos+2];
            textBox4.Text = temp[pos+3];
            textBox5.Text = temp[pos+4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = (((int)numericUpDown1.Value) - 1) * 5;
            temp[pos] = textBox1.Text;
            temp[pos+1] = textBox2.Text;
            temp[pos+2] = textBox3.Text;
            temp[pos+3] = textBox4.Text;
            temp[pos+4] = textBox5.Text;
        }
    }
}
