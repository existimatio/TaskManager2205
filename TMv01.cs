using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {

            //метод доступа


            static string ConnectToSQL(string login, string pass)
            {
                SqlConnection conn = new SqlConnection();

                conn.ConnectionString = @"Data Source = DESKTOP-35IES2U; Initial Catalog = TaskManagerData;" + "User ID = " + login + "; Password = " + pass + ";"
                string strSLQ = @"SELECT [User] as Us  FROM Users";
                conn.Open();

                SqlCommand cmd = new SqlCommand(strSLQ, conn);
                cmd.CommandTimeout = 1200000;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["Us"].ToString());
                }

                return conn;
            }

            static string CommandToSQL(char command)
            {
                //Блок комманд
                switch (number)  // (number) — выражение-селектор.
                {
                    // В теле переключателя switch-case, на 29 и 35 строках,
                    // создаем два оператора case, c постоянными выражениями равными "1" и "2" соответственно.

                    // Если значение выражения-селектора совпадет с одним из значений постоянных выражений,
                    // то выполняется тело оператора case, постоянное выражение которого, совпало с выражением-селектора. 

                    case "1":    // "1" — постоянное выражение.
                        {
                            Console.WriteLine("Один");                                       // Ветвь 1
                                                                                             // Выход из переключателя.
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Два");                                        // Ветвь 2
                            break;
                        }

                    // На 44 строке создаем (необязательный) оператор default, тело которого выполняется в случае,
                    // если значение выражения-селектора не совпадет ни с одним из значений постоянных выражений. 

                    default:
                        {
                            Console.WriteLine("Вы ввели значение отличное от 1 и 2.");       // Ветвь 3
                            break;
                        }

                        // Если в переключателе отсутствует оператор default, то управление передается за пределы переключателя switch.    
                }

            }

            static void CloseSQL()
            {
                // как закрыть sql соединение?ф
            }

            Console.WriteLine("Введите свой логин:");

            string login = Console.ReadLine();

            Console.WriteLine("Введите свой пароль:");

            string pass = Console.ReadLine();

            string status = ConnectToSQL(login, pass);




            conn.Close();

            Console.ReadKey();

        }
    }
}
