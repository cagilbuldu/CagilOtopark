using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CagilOtopark.Ekranlar.Abonelik
{
    public partial class AboneTipiEkleFrm : Form
    {
        public AboneTipiEkleFrm()
        {
            InitializeComponent();
        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string abonelikTipiAdi = txtAbonelikTipiAdi.Text;
            if (string.IsNullOrEmpty(abonelikTipiAdi))
            {
                MessageBox.Show("Abonelik Tipi Adı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int saatlikUcret;
            if (!int.TryParse(txtSaatlikUcret.Text, out saatlikUcret))
            {
                MessageBox.Show("Geçerli bir saatlik ücret giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string storedProcedure = "sp_AbonelikTipiEkle";

                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AbonelikTipiAdi", abonelikTipiAdi);
                    command.Parameters.AddWithValue("@SaatlikUcret", saatlikUcret);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Abonelik tipi başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            this.Close();

        }
    }
}
