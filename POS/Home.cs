using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel11.Controls.Clear();
            Administrimi frm2 = new Administrimi() { TopLevel = false, TopMost = true };
            panel11.Controls.Add(frm2);
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
            label2.Text = DateTime.Now.ToString("dd:MM:yyyy");
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
                }

        private void button1_Click(object sender, EventArgs e)
        {
            panel11.Controls.Clear();
            wp frm1 = new wp() { TopLevel = false, TopMost = true };
            panel11.Controls.Add(frm1);
            frm1.FormBorderStyle = FormBorderStyle.None;
          
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel11.Controls.Clear();
            Warehouse frm3 = new Warehouse() { TopLevel = false, TopMost = true };
            panel11.Controls.Add(frm3);
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel11.Controls.Clear();
            RAPORT frm4 = new RAPORT() { TopLevel = false, TopMost = true };
            frm4.FormBorderStyle = FormBorderStyle.None;
            panel11.Controls.Add(frm4);
            frm4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Shitje frm5 = new Shitje();
            this.Hide();
            frm5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel11.Controls.Clear();
            Artikujt frm6 = new Artikujt() { TopLevel = false, TopMost = true };
            frm6.FormBorderStyle = FormBorderStyle.None;
            panel11.Controls.Add(frm6);
            frm6.Show();

        }
    }
}
