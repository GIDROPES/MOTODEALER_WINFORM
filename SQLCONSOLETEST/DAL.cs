using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;

namespace SQLCONSOLETEST
{
    class DAL
    {
        static string connection = @"Data Source=LAPTOP-UTA4M5MF;
                Initial Catalog = MotoDealer; Integrated Security = True";

        public bool AddNewMotoToDB(string VIN_Number, string Moto_Name, string Moto_Type, int Engine_Volume, string Moto_Color,
            int Price, string Product_code)
        {
            bool result = false;

            string query = String.Format("INSERT INTO MotoInfo(VIN_Number, Moto_Name, Moto_Type, Engine_Volume, Moto_Color, Price, Product_code,Moto_is_Available)" +
                " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','1');", VIN_Number, Moto_Name, Moto_Type, Engine_Volume, Moto_Color, Price, Product_code);

            using(SqlConnection sqlCon = new SqlConnection(connection)) 
            {
                SqlCommand command = new SqlCommand(query, sqlCon);
                
                try {
                    sqlCon.Open();
                    int inf = 
                        command.ExecuteNonQuery();
                    if (inf == 1) result = true;
                }
                catch(SqlTypeException) { }
            }


            return result;
        }

        public bool AddToSalesJournal(string Date_Selling, string Product_Code,
            string client, string client_number, int ID_Consultant)
        {
            bool result = false;

            string query = String.Format("INSERT INTO Sales_Journal(Date_Selling, Product_Code, Client, Client_Number, ID_Consultant)" +
                " VALUES ('{0}','{1}','{2}','{3}',{4});", Date_Selling, Product_Code, client, client_number,  ID_Consultant);

            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, sqlCon);

                try
                {
                    sqlCon.Open();
                    int inf =
                        command.ExecuteNonQuery();
                    if (inf == 1) result = true;
                }
                catch (SqlTypeException) { }
            }


            return result;
        }

        public bool DeleteFromMotoInfo(string VIN_Number)
        {
            bool result = false;

            string query = String.Format("DELETE FROM MotoInfo" +
                " WHERE VIN_Number = '{0}';", VIN_Number);

            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, sqlCon);

                try
                {
                    sqlCon.Open();
                    int inf =
                        command.ExecuteNonQuery();
                    if (inf == 1) result = true;
                }
                catch (SqlTypeException) { }
            }


            return result;
        }

    }
}
