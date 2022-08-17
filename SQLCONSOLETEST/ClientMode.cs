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
    public partial class ClientMode : Form
    {
        string connectionStr = @"Data Source=LAPTOP-UTA4M5MF;
                Initial Catalog = MotoDealer; Integrated Security = True";

        static int index = 0;

        string[] motoModels = { 
        "XV950R",
        "MT-07",
        "YZF-R1",
        "YZF-R3",
        "YZF-R6",
        "NIKEN",
        "Tracer 900",
        "WR450F",
        "TT-R110E",
        "YZ450F",
        "RW50",
        "FJR1300" };

        string[] paths =
        {
            "C:\\Users\\MagicBook\\Desktop\\Motos\\XV950R.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\MT-07.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\YZF-R1.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\YZF-R3.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\YZF-R6.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\NIKEN.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\Tracer 900.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\WR450F.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\TT-R110E.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\YZ450F.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\RW50.png",
            "C:\\Users\\MagicBook\\Desktop\\Motos\\FJR1300.png",
        };

        string FIO, Number, MODEL_SALE, VIN_SALE,PRICE_SELL, ID_CONSULTANT, PRODUCT_CODE, date_now, client_name,consult_name;

        private void dataGrid_Cons_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ID_CONSULTANT = dataGrid_Cons.Rows[e.RowIndex].Cells[0].Value.ToString();
            consult_name = dataGrid_Cons.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (index == paths.Length-1)
            {
                index = 0;
                pb_MotoPic.ImageLocation = paths[index];
                lbl_model_name.Text = motoModels[index];
                txtbx_MODEL_SALE.Text = motoModels[index];
                if (getCountAvailable(motoModels[index]) > 0)
                {
                    lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                    lbl_SUMMA.BackColor = Color.Gold;
                    button1.BackColor = Color.PaleGreen; button1.Enabled = true;
                }
                else
                {
                    lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                    lbl_SUMMA.BackColor = Color.DarkRed;
                    button1.BackColor = Color.Gray; button1.Enabled = false;
                }
            }
            else
            {
                index++;
                pb_MotoPic.ImageLocation = paths[index];
                lbl_model_name.Text = motoModels[index];
                txtbx_MODEL_SALE.Text = motoModels[index];
                if (getCountAvailable(motoModels[index]) > 0)
                {
                    lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                    lbl_SUMMA.BackColor = Color.Gold;
                    button1.BackColor = Color.PaleGreen; button1.Enabled = true;
                }
                else
                {
                    lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                    lbl_SUMMA.BackColor = Color.DarkRed;
                    button1.BackColor = Color.Gray; button1.Enabled = false;
                }
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = paths.Length - 1;
                pb_MotoPic.ImageLocation = paths[index];
                lbl_model_name.Text = motoModels[index]; 
                txtbx_MODEL_SALE.Text = motoModels[index];
                if (getCountAvailable(motoModels[index]) > 0)
                {
                    lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                    lbl_SUMMA.BackColor = Color.Gold;
                    button1.BackColor = Color.PaleGreen; button1.Enabled = true;
                }
                else
                {
                    lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                    lbl_SUMMA.BackColor = Color.DarkRed;
                    button1.BackColor = Color.Gray; button1.Enabled = false;
                }
            }
            else {
                index--;
                pb_MotoPic.ImageLocation = paths[index];
                lbl_model_name.Text = motoModels[index];
                txtbx_MODEL_SALE.Text = motoModels[index];
                if (getCountAvailable(motoModels[index]) > 0) { 
                    lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                    lbl_SUMMA.BackColor = Color.Gold;
                    button1.BackColor = Color.PaleGreen; button1.Enabled = true;
                }
                else
                {
                    lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                    lbl_SUMMA.BackColor = Color.DarkRed;
                    button1.BackColor = Color.Gray; button1.Enabled = false;
                }
            }
            
        }


        public ClientMode()
        {
            InitializeComponent();
        }

        private void ClientMode_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "motoDealerDataSet4.MotoInfo". При необходимости она может быть перемещена или удалена.
            this.motoInfoTableAdapter1.Fill(this.motoDealerDataSet4.MotoInfo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "motoDealerDataSet3.Consultants". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "motoDealerDataSet2.MotoInfo". При необходимости она может быть перемещена или удалена.
            this.motoInfoTableAdapter.Fill(this.motoDealerDataSet2.MotoInfo);

            pb_MotoPic.ImageLocation = paths[index];
            lbl_model_name.Text = motoModels[index];
            txtbx_MODEL_SALE.Text = motoModels[index];
            if (getCountAvailable(motoModels[index]) > 0)
            {
                lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                lbl_SUMMA.BackColor = Color.Gold;
                button1.BackColor = Color.PaleGreen; button1.Enabled = true;
            }
            else
            {
                lbl_SUMMA.Text = getCountAvailable(motoModels[index]).ToString();
                lbl_SUMMA.BackColor = Color.DarkRed;
                button1.BackColor = Color.Gray; button1.Enabled = false;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Consultants;", sqlCon);

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dataGrid_Cons.DataSource = table;
                dataGrid_Cons.Columns[0].Visible = false;
            }

            

        }

        private void dgv_MotoForSale_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           /* MODEL_SALE = dgv_MotoForSale.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbx_MODEL_SALE.Text = MODEL_SALE;

            VIN_SALE = dgv_MotoForSale.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbx_VIN_SALE.Text = VIN_SALE;

            PRICE_SELL = dgv_MotoForSale.Rows[e.RowIndex].Cells[5].Value.ToString();
            lbl_SUMMA.Text = PRICE_SELL;

            PRODUCT_CODE = dgv_MotoForSale.Rows[e.RowIndex].Cells[6].Value.ToString();
           */
        }

        public int getCountAvailable(string motoModel)
        {
            int result = 0;
            string command = String.Format("SELECT COUNT(*) FROM MotoInfo WHERE Moto_Name = '{0}' AND Moto_is_Available = 1;", motoModel);

            using(SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    SqlCommand commandSql = new SqlCommand(command,connection);
                    result = (int) commandSql.ExecuteScalar();

                }
                catch (SqlException) { }
                finally { connection.Close(); }
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            date_now = DateTime.Now.ToString();
            Random random = new Random();
            FIO = txtbx_FIO.Text;
           // ID_Selling = random.Next(10000, 500000);
            Number = txtbx_TEL_NUMBER.Text;
            client_name = txtbx_FIO.Text;

            if(!FIO.Equals("") && !Number.Equals(""))
            {   
                if(ID_CONSULTANT == null) { MessageBox.Show("Выберите консультанта", "Ошибка", MessageBoxButtons.OK); }
                try
                {
                    UpdateInfo updateInfo = new UpdateInfo(txtbx_MODEL_SALE.Text, Int32.Parse(ID_CONSULTANT),consult_name,client_name, Number);
                    updateInfo.Show();
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                }

               
            }
            else MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
