using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS
{
    public partial class Administrimi : Form
    {
        int count = 0;
        int county = 0;
        public Administrimi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            count++;
            textBox3.Text = count.ToString();
        }

        private void Administrimi_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            count--;
            textBox3.Text = count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            county++;
            textBox4.Text = county.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            county--;
            textBox4.Text = county.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = XPOS; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Insert into Tavol  Nrtav=@nrtav ",con);

            con.Open();
            for(int i = 0; i < count; i++)
            {
                cmd.Parameters.AddWithValue("nrtav",count);
                cmd.ExecuteNonQuery();
            }

            con.Close();

        }
    }
}
