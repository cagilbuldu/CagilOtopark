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
    public partial class AboneListesiFrm : Form
    {
        public AboneListesiFrm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void AboneListesiFrm_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT AboneID, PlakaNumarasi, BaslangicTarihi, tb_AbonelikTipi.AbonelikTipiAdi " +
                              "FROM tb_Aboneler " +
                              "INNER JOIN tb_AbonelikTipi ON tb_Aboneler.AbonelikTipiID = tb_AbonelikTipi.AbonelikTipiID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgViewAboneListesi.DataSource = dt;
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgViewAboneListesi.SelectedRows[0];

            if (selectedRow != null)
            {
                int aboneID = Convert.ToInt32(selectedRow.Cells["AboneID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "sp_AboneSil";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AboneID", aboneID);

                        connection.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Abone başarıyla silindi.");

                        AboneListesiFrm_Load(sender, e); 
                    }
                }
            }
        }
    }
}
