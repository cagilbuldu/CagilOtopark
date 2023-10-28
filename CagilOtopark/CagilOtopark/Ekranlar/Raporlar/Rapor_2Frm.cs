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

namespace CagilOtopark.Ekranlar.Raporlar
{
    public partial class Rapor_2Frm : Form
    {
        public Rapor_2Frm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void btnAra_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = tctPlaka.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string query = "SELECT GirisTarihiSaat, CikisTarihiSaat, ToplamUcret FROM tb_GirisCikisKayitlari WHERE PlakaNumarasi = @PlakaNumarasi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlakaNumarasi", plakaNumarasi);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    dgvRapor2.Rows.Clear();

                    dgvRapor2.Columns.Add("GirisTarihiSaat", "Giriş Tarihi/Saat");
                    dgvRapor2.Columns.Add("CikisTarihiSaat", "Çıkış Tarihi/Saat");
                    dgvRapor2.Columns.Add("ToplamUcret", "Toplam Ücret");
                    foreach (DataRow row in results.Rows)
                    {
                        dgvRapor2.Rows.Add(row["GirisTarihiSaat"], row["CikisTarihiSaat"], row["ToplamUcret"]);
                    }

                    int totalEarnings = results.AsEnumerable().Sum(row => row.Field<int?>("ToplamUcret") ?? 0);

                    lblToplamKazanc.Text = "Toplam Kazanç: " + totalEarnings.ToString("C");
                }
            }
        }
    }
}
