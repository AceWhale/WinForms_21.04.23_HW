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
    public partial class Check : Form
    {
        public Form1 frm;
        public Check()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                frm.AdminCreate();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Show();
            Close();
        }
    }
}
