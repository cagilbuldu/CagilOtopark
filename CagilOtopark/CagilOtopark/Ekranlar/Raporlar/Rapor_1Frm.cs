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
    public partial class Rapor_1Frm : Form
    {
        public Rapor_1Frm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void GunlukKazancHesapla()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(ToplamUcret) AS ToplamKazanc " +
                               "FROM tb_GirisCikisKayitlari " +
                               "WHERE CONVERT(DATE, GirisTarihiSaat) = CONVERT(DATE, GETDATE())";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("ToplamKazanc")))
                        {
                            int toplamKazanc = reader.GetInt32(reader.GetOrdinal("ToplamKazanc"));
                            lblGunlukKazanc.Text = "Günlük Kazanç: " + toplamKazanc.ToString("C");
                        }
                    }
                }
            }
        }
        private void HaftalikKazancHesapla()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string query = "SELECT SUM(ToplamUcret) AS HaftalikKazanc\r\nFROM tb_GirisCikisKayitlari\r\nWHERE GirisTarihiSaat >= DATEADD(DAY, -7, GETDATE())\r\n";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("HaftalikKazanc")))
                        {
                            int toplamKazanc = reader.GetInt32(reader.GetOrdinal("HaftalikKazanc"));
                            lblHaftalikKazanc.Text = "Haftalık Kazanç: " + toplamKazanc.ToString("C");
                        }
                    }
                }
            }
        }
        private void AylikKazancHesapla()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT SUM(ToplamUcret) AS AylikKazanc\r\nFROM tb_GirisCikisKayitlari\r\nWHERE GirisTarihiSaat >= DATEADD(MONTH, -1, GETDATE())\r\n";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("AylikKazanc")))
                        {
                            int toplamKazanc = reader.GetInt32(reader.GetOrdinal("AylikKazanc"));
                            lblAylikKazanc.Text = "Aylık Kazanç: " + toplamKazanc.ToString("C");
                        }
                    }
                }
            }
        }

        private void Rapor_1Frm_Load(object sender, EventArgs e)
        {
            GunlukKazancHesapla();
            HaftalikKazancHesapla();
            AylikKazancHesapla();

            string query1 = "SELECT * FROM tb_GirisCikisKayitlari WHERE CAST(GirisTarihiSaat AS DATE) = CAST(GETDATE() AS DATE)";
            string query2 = "SELECT * FROM tb_GirisCikisKayitlari WHERE DATEPART(WEEK, GirisTarihiSaat) = DATEPART(WEEK, GETDATE())";
            string query3 = "SELECT * FROM tb_GirisCikisKayitlari WHERE DATEPART(MONTH, GirisTarihiSaat) = DATEPART(MONTH, GETDATE())";

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            dgvGunlukKazanc.DataSource = dataTable;


            DataTable dataTable2 = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable2);
                    }
                }
            }
            dgvHaftalikKazanc.DataSource = dataTable2;


            DataTable dataTable3 = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query3, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable3);
                    }
                }
            }
            dgvAylikKazanc.DataSource = dataTable3;

        }

    }
}
