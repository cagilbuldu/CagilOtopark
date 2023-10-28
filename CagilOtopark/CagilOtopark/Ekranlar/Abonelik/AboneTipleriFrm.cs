using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CagilOtopark.Ekranlar.Abonelik
{
    public partial class AboneTipleriFrm : Form
    {
        public AboneTipleriFrm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\;database=DbOtopark;integrated security=true";

        private void AboneTipleriFrm_Load(object sender, EventArgs e)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT AbonelikTipiID, AbonelikTipiAdi, SaatlikUcret FROM tb_AbonelikTipi";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "tb_AbonelikTipi");
                dataGridView1.DataSource = dataSet.Tables["tb_AbonelikTipi"];
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            if (selectedRow != null)
            {
                int abonelikTipiID = Convert.ToInt32(selectedRow.Cells["AbonelikTipiID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    string query = "sp_AbonelikTipiSil";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AbonelikTipiID", abonelikTipiID);

                        connection.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Kayıt başarıyla silindi.");

                        AboneTipleriFrm_Load(sender, e); 
                    }
                }
            }
        }

        

       

        private void btnkaydiduzelt_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
