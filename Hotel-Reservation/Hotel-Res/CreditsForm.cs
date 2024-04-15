using Hotel_Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Res
{
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 koce = new Form1();
            koce.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            title.Text = comboBox1.Text;
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label1.Show();
                label2.Show();
                label3.Hide();
                label4.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label1.Hide();
                label2.Hide();
                label3.Show();
                label4.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
