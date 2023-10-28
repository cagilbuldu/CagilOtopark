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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CagilOtopark.Ekranlar.Raporlar
{
    public partial class Rapor_3Frm : Form
    {
        public Rapor_3Frm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void btnAra_Click(object sender, EventArgs e)
        {
            //string selectedAbonelikTipi = cmbAbone.SelectedItem as string;

            //if (selectedAbonelikTipi != null)
            //{

            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();

            //        string query = "SELECT GirisTarihiSaat, CikisTarihiSaat, ToplamUcret FROM tb_GirisCikisKayitlari " +
            //   "INNER JOIN tb_AbonelikTipi ON tb_GirisCikisKayitlari.AbonelikTipiID = tb_AbonelikTipi.AbonelikTipiID " +
            //   "WHERE tb_AbonelikTipi.AbonelikTipiAdi = @AbonelikTipiAdi";




            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@AbonelikTipiAdi", selectedAbonelikTipi);

            //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //            {
            //                DataTable dataTable = new DataTable();
            //                adapter.Fill(dataTable);

            //                dgvRapor3.DataSource = dataTable;

            //                int toplamKazanc = 0;

            //                foreach (DataRow row in dataTable.Rows)
            //                {
            //                    toplamKazanc += Convert.ToInt32(row["ToplamUcret"]);
            //                }

            //                MessageBox.Show("Toplam Kazanç: " + toplamKazanc.ToString("C"));
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen bir abonelik tipi seçin.");
            //}
        }

        private void cmbAbone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rapor_3Frm_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT AbonelikTipiAdi FROM tb_AbonelikTipi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbAbone.Items.Add(reader["AbonelikTipiAdi"].ToString());
                        }
                    }
                }
            }
        }
    }
}
