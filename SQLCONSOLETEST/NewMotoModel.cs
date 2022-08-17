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
    public partial class NewMotoModel : Form
    {

        string connectionStr = @"Data Source=LAPTOP-UTA4M5MF;
                Initial Catalog = MotoDealer; Integrated Security = True";
        public NewMotoModel()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                bool result = false;
                sqlCon.Open();
                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Available_Motorcycles " +
                    "(MotoModel, MotoPower, MotoType, MotoPrice) " +
                    "VALUES ('{0}','{1}','{2}','{3}')",txbx_ModelName.Text,txbx_MotoPower.Text,txbx_MotoType.Text,txbx_MotoPrice.Text), sqlCon);
                try
                {
                    int r = command.ExecuteNonQuery();
                    if (r == 1) result = true;
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK); }

                if (result) { MessageBox.Show("Мотоцикл добавлен", "Успех", MessageBoxButtons.OK); }
                this.Close();
                sqlCon.Close();
            }
        }

        private void NewMotoModel_Load(object sender, EventArgs e)
        {

        }
    }
}
