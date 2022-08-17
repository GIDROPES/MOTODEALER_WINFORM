using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLCONSOLETEST
{
    public partial class AddNewMoto : Form
    {
        string VIN;
        string product_code;
        string price;
        string moto_name;
        string moto_type;
        string engine_volume;

        public AddNewMoto()
        {
            InitializeComponent();
        }

        private void AddNewMoto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "motoDealerDataSet1.Available_Motorcycles". При необходимости она может быть перемещена или удалена.
            this.available_MotorcyclesTableAdapter1.Fill(this.motoDealerDataSet1.Available_Motorcycles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "motoDealerDataSet.Available_Motorcycles". При необходимости она может быть перемещена или удалена.
            this.available_MotorcyclesTableAdapter.Fill(this.motoDealerDataSet.Available_Motorcycles);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_Model_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            moto_type = dgv_Model.Rows[e.RowIndex].Cells[2].Value.ToString();
            Random random = new Random();
            int code = random.Next(999, 10000);
            int vindop = random.Next(999999, 10000000);

            switch (moto_type)
            {
                case "Круизер": product_code = "KS-" + code; VIN = "JYA-RK01K-" + vindop;
                    break;
                case "Нейкед": product_code = "ND-" + code;  VIN = "JYA-RN01E-" + vindop;
                    break;
                case "Суперспорт": product_code = "SS-" + code; VIN = "JYA-RJ06E-" + vindop;
                    break;
                case "Туристический": product_code = "TS-" + code; VIN = "JYA-RJ06E-" + vindop;
                    break;
                case "Внедорожный": product_code = "VD-" + code; VIN = "JYA-NR08A-" + vindop;
                    break;
                case "Детский": product_code = "VD-" + code; VIN = "JYA-TT110E-" + vindop;
                    break;
                
            }

            txtbx_VIN.Text = VIN;

            price = dgv_Model.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbx_PRICE.Text = price;

            moto_name = dgv_Model.Rows[e.RowIndex].Cells[0].Value.ToString();
            engine_volume = dgv_Model.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_ADDMoto_Click(object sender, EventArgs e)
        {
            string moto_color = txtbx_COLOR.Text;

            DAL dal = new DAL();
            bool v = false;

            if (!moto_color.Equals("")) { v = dal.AddNewMotoToDB(VIN, moto_name, moto_type, int.Parse(engine_volume), moto_color, int.Parse(price), product_code); this.Close(); AdminMode admin = new AdminMode(); admin.Show();  }
            else MessageBox.Show("Введите цвет", "Осторожнее", MessageBoxButtons.OK);

            



            if (v) MessageBox.Show("Заказ успешен", "OK",MessageBoxButtons.OK);
            else MessageBox.Show("Не удалось оформить заказ", "Отмена", MessageBoxButtons.OK);
        }

        private void txtbx_VIN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
