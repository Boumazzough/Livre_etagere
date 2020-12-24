using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
using MetroFramework;
namespace Livre_etagere
{
    public partial class Form3 : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GI_2\S8\Technologies Dot net\Corr_TPs\Livre_etagere\Livre_etagere\Database1.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "")
            { MetroMessageBox.Show(this, "Veuillez remplir le champ vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into etagere (numero) values ('" + metroTextBox1.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                MetroMessageBox.Show(this, "Bingo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroTextBox1.Text = "";
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
