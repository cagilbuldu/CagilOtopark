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

namespace CagilOtopark.Ekranlar.OtoparkCikis
{
    public partial class OtoparkCikisFrm : Form
    {
        public OtoparkCikisFrm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            string plakaNumarasi = txtPlaka.Text;
            DateTime cikisTarihiSaat = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_CikisKaydiEkle", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PlakaNumarasi", plakaNumarasi);
                    command.Parameters.AddWithValue("@CikisTarihiSaat", cikisTarihiSaat);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Çıkış kaydı başarıyla eklendi.");
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
