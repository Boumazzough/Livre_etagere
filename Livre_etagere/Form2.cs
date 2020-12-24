using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Livre_etagere
{
    public partial class Form2 : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GI_2\S8\Technologies Dot net\Corr_TPs\Livre_etagere\Livre_etagere\Database1.mdf;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "" && metroTextBox2.Text == "" && metroTextBox3.Text == "")
            { MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                
                string code = metroTextBox1.Text;
                string titre = metroTextBox2.Text;
                int prix = int.Parse(metroTextBox3.Text);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [livre] (code, titre,prix) values ('" + code + "','" + titre + "','" +prix + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                MetroMessageBox.Show(this, "Bingo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";

            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
