using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
/// <summary>
/// ///////  flow layout panel per buttonat , 
/// </summary>
namespace POS
{
    public partial class Shitje : Form
    {
        public static string passingtext;
        public static string nrtav;

        public Shitje()
        {
            InitializeComponent();
        }
        void b_Click(object sender, EventArgs e)
        {
            passingtext =nrtav;
            ORDER frm2 = new ORDER();
            this.Hide();
            frm2.Show();
        }
        private void Shitje_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = XPOS; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tavol",con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + dt.Rows[i][1];
                btn.Tag = dt.Rows[i][1];
                btn.Size = new Size ( 150, 120 );
                byte []data=(byte[])dt.Rows[i][2];
                MemoryStream ms = new MemoryStream(data);

                btn.Image = Image.FromStream(ms);
                btn.Text = dt.Rows[i][1].ToString();
                btn.Click += b_Click;
                flowLayoutPanel1.Controls.Add(btn);
               
            }


            con.Close();



        }

        private void B_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

   
    }
    

