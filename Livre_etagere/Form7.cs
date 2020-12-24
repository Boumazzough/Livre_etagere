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
using System.Data.SqlClient;
namespace Livre_etagere
{
    public partial class Form7 : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GI_2\S8\Technologies Dot net\Corr_TPs\Livre_etagere\Livre_etagere\Database1.mdf;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'biblioDataSet.livre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.livreTableAdapter.Fill(this.biblioDataSet.livre);
            // TODO: cette ligne de code charge les données dans la table 'biblioDataSet.etagere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.etagereTableAdapter.Fill(this.biblioDataSet.etagere);

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "" )
            { MetroMessageBox.Show(this, "Veuillez remplir le champ vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {

                string N_etagere = metroComboBox1.Text;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [livre] where Nb_etagere = '"+N_etagere+"'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
                dataadp.Fill(dta);
                metroGrid1.DataSource = dta;
                connection.Close();
                metroComboBox1.Text = "";

            }
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
