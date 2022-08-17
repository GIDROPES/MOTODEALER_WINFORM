
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
    class Program
    {
        static string connection = @"Data Source=LAPTOP-UTA4M5MF;
                Initial Catalog = UniversityDB; Integrated Security = True";
        static void Main(string[] args)
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());

            /*  using (SqlConnection sqlConnection = new SqlConnection(connection))
              {
                   Console.WriteLine("Введите группу студента");
                   string @group = Console.ReadLine();

                   Console.WriteLine("Введите ФИО студента");
                   string @fio = Console.ReadLine();

                   Console.WriteLine("Введите стипендию студента. Если отсутствует, введите 0");
                   int @stip = Int32.Parse(Console.ReadLine());
                   if (@stip.Equals(0)) { @stip = 0; }

                   Console.WriteLine("Введите куратора группы студента. Если отсутствует, введите 0");
                   string kurator = Console.ReadLine();
                   if (@kurator.Equals("0")) { @kurator = "Null"; }

                   string sqlExpression = String.Format("INSERT INTO [Students] (Группа, ФИО, Стипендия, Куратор) VALUES('{0}', '{1}', {2},'{3}');SET @id=SCOPE_IDENTITY()", @group, @fio, @stip, @kurator);
                   sqlConnection.Open();
                   /* SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);

                   SqlParameter grPar = new SqlParameter("@group", group);
                   command.Parameters.Add(grPar);
                   SqlParameter fioPar = new SqlParameter("@fio", fio);
                   command.Parameters.Add(fioPar);
                   SqlParameter stPar = new SqlParameter("@stip", stip);
                   command.Parameters.Add(stPar);
                   SqlParameter kurPar = new SqlParameter("@kurator", kurator);
                   command.Parameters.Add(kurPar);

                   SqlParameter idPar = new SqlParameter {
                       ParameterName = "@id",
                       SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output
                   };

                   int v = command.ExecuteNonQuery();

                   //20-ИО','эй', 1600, 'Никонова А. В'); INSERT INTO [Students] (Группа, ФИО, Стипендия, Куратор) VALUES('20-ИО','Патраков И.А.',0,'Никонова')

                   Console.WriteLine("ID новой записи", idPar.Value);

                  InsertStudent(group,fio,stip,kurator);
                  GetStudents();
            */
        }
        //Console.Read();
    }
}
    /*
        private static void GetStudents()
        {
            // название процедуры
            string sqlExpression = "sp_GetUsers";
            using (SqlConnection connectionSql = new SqlConnection(connection))
            {
                connectionSql.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connectionSql);

                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader.GetName(0),
                   reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4));
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string group = reader.GetString(1);
                        string fio = reader.GetString(2);
                        int stip = 0;
                        try
                        { stip = reader.GetInt32(3); }
                        catch (SqlNullValueException ex)
                        {
                            //Console.WriteLine("\t\t\tNULL");
                            //Console.WriteLine(ex.Message);
                        }
                        string kurator = "Null";
                        try
                        {
                            kurator = reader.GetString(4);
                        }
                        catch (SqlNullValueException ex2) { }

                        Console.WriteLine("{0} \t{1} \t{2}\t{3}\t{4}", id, group, fio, stip, kurator);       /////////////////
                    }
                }
                reader.Close();
            }
        }
        private static void InsertStudent(string group, string fio, int stip, string kurator)
        {
            string sqlExpression = "pr_Insert_Student";
            using (SqlConnection connectionSql = new SqlConnection(connection))
            {
                connectionSql.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connectionSql);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter grPar = new SqlParameter("@Группа", group);
                SqlParameter fioPar = new SqlParameter("@ФИО", fio);
                SqlParameter stipPar = new SqlParameter("@Стипендия", stip);
                SqlParameter kurPar = new SqlParameter("@Куратор", kurator);
                command.Parameters.Add(grPar); command.Parameters.Add(fioPar);
                command.Parameters.Add(stipPar); command.Parameters.Add(kurPar);

                var result = command.ExecuteScalar();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
        }
    }
}
    */
