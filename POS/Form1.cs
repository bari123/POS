using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("gabim");
            }
            SqlDataReader  mr;
           
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = XPOS; Integrated Security = True");

                SqlCommand cmd = new SqlCommand("Select * from usrs where PIN=@pini", con);
                cmd.Parameters.AddWithValue("@pini", textBox1.Text);
                con.Open();
            mr = cmd.ExecuteReader();
                // SqlDataAdapter da = new SqlDataAdapter(cmd);
                // DataSet ds = new DataSet();
                // da.Fill(ds);
                // con.Close();

                //  int count = ds.Tables[0].Rows.Count;
                string userrole = string.Empty;
                int count = 0;
            while (mr.Read())
            {
                count = count + 1;
                userrole = mr["roli"].ToString();
            }
            if (count == 1)
            {
                
                if (userrole == "adm")
                {
                    Home frm1 = new Home();
                    this.Hide();
                    frm1.Show();
                }
                else
                {
                    Shitje frm2 = new Shitje();
                    this.Hide();
                    frm2.Show();
                }
            }

            //    if (count == 1)
            //    {

            //        home frm1 = new home();
            //        frm1.show();
            //        this.hide();
            //    }
            //    else
            //    {
            //        textbox1.clear();
            //        messagebox.show("gabim");
            //    }

            //}
            //catch (exception ex)
            //{
            //    messagebox.show(ex.message);
            //}


        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Focus();

            if (textBox1.SelectionLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            

        }
    }

    }

