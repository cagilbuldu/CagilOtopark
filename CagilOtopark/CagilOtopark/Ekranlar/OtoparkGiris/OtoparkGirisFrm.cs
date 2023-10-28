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

namespace CagilOtopark.Ekranlar.OtoparkGiris
{
    public partial class OtoparkGirisFrm : Form
    {
        public OtoparkGirisFrm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = txtPlaka.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GirisKaydiEkle", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PlakaNumarasi", plakaNumarasi);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Giriş kaydı başarıyla eklendi.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            txtPlaka.Text = "";
        }
    }
}
