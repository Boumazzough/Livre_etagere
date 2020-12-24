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
    public partial class Form6 : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GI_2\S8\Technologies Dot net\Corr_TPs\Livre_etagere\Livre_etagere\Database1.mdf;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'biblioDataSet.livre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.livreTableAdapter.Fill(this.biblioDataSet.livre);
            // TODO: cette ligne de code charge les données dans la table 'biblioDataSet.etagere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.etagereTableAdapter.Fill(this.biblioDataSet.etagere);

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "" && livreComboBox1.Text == "" && livreComboBox.Text=="")
            { MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {

                string code1 = livreComboBox1.Text;
                string Nb_etagere = metroComboBox1.Text;
                string code2 = livreComboBox.Text;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [livre] set Nb_etagere='"+Nb_etagere+"'where code='"+code2+"'";
                cmd.ExecuteNonQuery();
                connection.Close();
                MetroMessageBox.Show(this, "Bingo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroComboBox1.Text = "";
                livreComboBox1.Text = "";
                livreComboBox.Text = "";


            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
