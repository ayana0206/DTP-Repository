using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace SQL_Injection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte Name eingeben:");

            string name = Console.ReadLine();

            ReadMitarbeiter(name);
            
        }


        private static void ReadMitarbeiter(String name) {
            MySqlConnection conn = null;
            try
            {
                // name = MySqlHelper.EscapeString(name); -> escaped das hoch^komme und macht es sicher

                // Prepared Statements

                // 1. Connection initialisierung 
                // connectionstrings.com
                var connStr = "Server=localhost;Database=sqlteacherdb;Uid=root;Pwd=;";
                conn = new MySqlConnection(connStr);

                // 2. Conecction öffnen 
                conn.Open();

                // 3. Command deklarieren
                var cmd = conn.CreateCommand();
                cmd.CommandText = $"select Name, Vorname, Ort from mitarbeiter where name like @pName";
                // Prepared Statements 
                cmd.Parameters.AddWithValue("@pName", $"{name}%");

                // 4. Command ausführen 
                var reader = cmd.ExecuteReader();

                // 5. Ergebnis verarbeiten
                while (reader.Read())
                {
                    Console.Write(reader.GetString(0) + "  |  ");

                    Console.Write(reader.GetString(1) + "  |  ");

                    Console.Write(reader.GetString(2));

                    Console.WriteLine();
                }

                // 6. Connection schliessen
                reader.Close();
                conn.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Es ist ein Problem aufgetreten: " + ex.Message);
            } finally { 
                if (conn != null) {
                    conn.Close();
                }
            }
        }
    }
}
