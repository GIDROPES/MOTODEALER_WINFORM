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
    public partial class AdminMode : Form
    {
        string connectionStr = @"Data Source=LAPTOP-UTA4M5MF;
                Initial Catalog = MotoDealer; Integrated Security = True";
        public AdminMode()
        {
            InitializeComponent();
        }

        private void AdminMode_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "motoDealerDataSet6.Sales_Journal". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "motoDealerDataSet5.Sales_Journal". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "motoInfoDataSet.MotoInfo". При необходимости она может быть перемещена или удалена.

            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand("SELECT [MotoInfo].VIN_Number,[MotoInfo].Moto_Name,[MotoInfo].Moto_Type," +
                    "[MotoInfo].Engine_Volume," +
                    "[MotoInfo].Price,[MotoInfo].Moto_Color FROM MotoInfo " +
                    "WHERE" +
                    " [MotoInfo].Moto_is_Available = 1;", sqlCon);

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgv_motoAvailable.DataSource = table;
            }

            using(SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand("SELECT [MotoInfo].VIN_Number,[MotoInfo].Moto_Name,[MotoInfo].Moto_Type," +
                    "[MotoInfo].Engine_Volume," +
                    "[MotoInfo].Price,[Consultants].Consulant_Name,[Clients].Client_FIO,[Clients].Client_Number FROM MotoInfo," +
                    "Consultants,Clients " +
                    "WHERE [MotoInfo].ID_OF_CONSULTANT = Consultant_ID AND [MotoInfo].ID_OF_CLIENT = [Clients].Client_ID AND" +
                    " [MotoInfo].Moto_is_Available = 0;", sqlCon);
                
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgv_Journal.DataSource = table;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btn_addNewMoto_Click(object sender, EventArgs e)
        {
            AddNewMoto addMoto = new AddNewMoto();
            addMoto.Show();
            this.Close();
        }

        private void dgv_Journal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewConsultant newConsultant = new NewConsultant();
            newConsultant.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewMotoModel moto = new NewMotoModel();
            moto.Show();
        }
    }
}
