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

namespace SQLCONSOLETEST
{
    public partial class UpdateInfo : Form
    {
        string connectionStr = @"Data Source=LAPTOP-UTA4M5MF;
                Initial Catalog = MotoDealer; Integrated Security = True";

        string moto_name, consultant_name,client_name,number;
        int consultant_id;
        string VIN_NUMBER;

        private void btn_accept_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();

                SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM Clients;", sqlCon);
                int res = (int) comm.ExecuteScalar();

                SqlTransaction transaction = sqlCon.BeginTransaction();
            
                SqlCommand command = sqlCon.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = string.Format("INSERT INTO Clients (Client_ID, Client_FIO, Client_Number) VALUES({0},'{1}','{2}');",res+1, client_name, number);
                    command.ExecuteNonQuery();
                    command.CommandText = string.Format("SELECT Client_ID FROM Clients WHERE Client_FIO = '{0}';", client_name);
                    int id_client = (int) command.ExecuteScalar();
                    command.CommandText = string.Format("UPDATE MotoInfo SET Moto_is_Available = 0, ID_OF_CLIENT = {0}, ID_OF_CONSULTANT = {1} WHERE" +
                        " VIN_NUMBER = '{2}';", id_client, consultant_id, VIN_NUMBER);
                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (SqlException ex) { string inf = ex.Message; }
                sqlCon.Close();
                Application.Restart();
            }
        }

        private void dgv_YourMoto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            VIN_NUMBER = dgv_YourMoto.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void lbl_for_client_Click(object sender, EventArgs e)
        {

        }

        public UpdateInfo(string moto_n, int consult_id, string consult_n, string client_na, string client_number)
        {
            InitializeComponent();
            moto_name = moto_n;
            consultant_id = consult_id;
            consultant_name = consult_n;
            client_name = client_na;
            number = client_number;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            { string query = String.Format("SELECT VIN_Number, Moto_Name, Moto_Type,Engine_Volume, Moto_Color,Price FROM MotoInfo WHERE Moto_Name = '{0}';",moto_name);
                sqlCon.Open();
                SqlCommand command = new SqlCommand(query, sqlCon);

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgv_YourMoto.DataSource = table;
            }
            lbl_for_client.Text = String.Format("{0}, выберите конкретный мотоцикл. Вас проконсультирует {1}", client_name, consultant_name);
            
        }
    }
}
