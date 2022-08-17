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

    public partial class NewConsultant : Form
    {
        string connectionStr = @"Data Source=LAPTOP-UTA4M5MF;
                Initial Catalog = MotoDealer; Integrated Security = True";
        public NewConsultant()
        {
            InitializeComponent();
        }

        private void btn_CreateCons_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int newID = rand.Next(110, 999);

            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                bool result = false;
                sqlCon.Open();
                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Consultants (Consultant_ID,Consulant_Name, Consultant_Phone, Consultant_Mail) " +
                    "VALUES ({0},'{1}','{2}','{3}');",newID, txbx_ConsName.Text, txbx_ConsPhone.Text, txbx_ConsMail.Text), sqlCon);
                try
                {
                    int r = command.ExecuteNonQuery();
                    if (r == 1) result = true;
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK); }

                if (result) { MessageBox.Show("Консультант добавлен", "Успех", MessageBoxButtons.OK); }
                this.Close();
                sqlCon.Close();
            }
        }
    }
}
