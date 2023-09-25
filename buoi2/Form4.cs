using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 textBox1.Text = (Convert.ToDouble( textBox1.Text)).ToString();
                 textBox2.Text = (Convert.ToDouble( textBox2.Text)).ToString();
                 textBox3.Text = (Convert.ToDouble( textBox1.Text) + Convert.ToDouble( textBox2.Text)).ToString();
               
            }
            catch
            {
                MessageBox.Show("ban nhap sai du lieu ", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 textBox1.Text = (Convert.ToDouble( textBox1.Text)).ToString();
                 textBox2.Text = (Convert.ToDouble( textBox2.Text)).ToString();
                 textBox3.Text = (Convert.ToDouble( textBox1.Text) * Convert.ToDouble( textBox2.Text)).ToString();
               
            }
            catch
            {
                MessageBox.Show("ban nhap sai du lieu ", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

