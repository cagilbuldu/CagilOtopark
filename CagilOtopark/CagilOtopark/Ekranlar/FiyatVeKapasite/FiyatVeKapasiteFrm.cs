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

namespace CagilOtopark.Ekranlar.FiyatVeKapasite
{
    public partial class FiyatVeKapasiteFrm : Form
    {
        public FiyatVeKapasiteFrm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            int varsayilanFiyat = Convert.ToInt32(nmrVarsayilanFiyat.Value);
            int kapasite = Convert.ToInt32(nmrKapasite.Value);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_AyarGuncelle", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AyarID", 1);
                    command.Parameters.AddWithValue("@Kapasite", kapasite);
                    command.Parameters.AddWithValue("@VarsayilanFiyat", varsayilanFiyat);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Ayarlar kaydedildi.");
                }
                this.Close();
            }
        }

        private void FiyatVeKapasiteFrm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT VarsayilanFiyat, Kapasite FROM tb_Ayarlar WHERE AyarID = 1"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nmrVarsayilanFiyat.Value = Convert.ToInt32(reader["VarsayilanFiyat"]);
                        nmrKapasite.Value = Convert.ToInt32(reader["Kapasite"]);
                    }
                }
            }
        }
    }
}
