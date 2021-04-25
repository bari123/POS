using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class ORDER : Form
    {

        public ORDER()
        {
            InitializeComponent();
        }

        private void ORDER_Load(object sender, EventArgs e)
        {
            label2.Text = Shitje.passingtext;
        }
        int count = 1;
        int x = 0;
       

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                var b = new Button();
                b.Text = count.ToString();
                b.Name = count.ToString();
                b.Size = new Size(200,140);
                b.Image = Image.FromFile("D:\\props\\download.jpg");
                b.FlatStyle = FlatStyle.Flat;
                b.Font = new Font("Lucida Sans Unicode", 16, FontStyle.Bold);
                b.ForeColor = Color.White;
               
                x++;
                count++;

                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uc = new UserControl1();

            flowLayoutPanel2.Controls.Add(uc);
        }
    }
}
