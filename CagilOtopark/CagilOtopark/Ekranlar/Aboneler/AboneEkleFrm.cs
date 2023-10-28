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

namespace CagilOtopark.Ekranlar.Aboneler
{
    public partial class AboneEkleFrm : Form
    {
        public AboneEkleFrm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void button1_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = txtPlakaNumarasi.Text;
            DateTime baslangicTarihi = dateTimePickerBaslangicTarihi.Value;
            int abonelikTipiID = (int)comboBoxAbonelikTuru.SelectedValue; 


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "sp_AboneEkle";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PlakaNumarasi", plakaNumarasi);
                    command.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    command.Parameters.AddWithValue("@AbonelikTipiID", abonelikTipiID);

                    connection.Open();

                    command.ExecuteNonQuery();

                    MessageBox.Show("Abone başarıyla eklenmiştir.");
                }
            }
            txtPlakaNumarasi.Text = "";
        }

        private void AboneEkleFrm_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT AbonelikTipiID, AbonelikTipiAdi FROM tb_AbonelikTipi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxAbonelikTuru.DataSource = dt;
                    comboBoxAbonelikTuru.DisplayMember = "AbonelikTipiAdi"; 
                    comboBoxAbonelikTuru.ValueMember = "AbonelikTipiID"; 
                }
            }
        }
    }
}
