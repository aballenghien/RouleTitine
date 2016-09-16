using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Web;

namespace GestionVoiture
{
    class ConnexionSql
    {
        private static ConnexionSql instance;
        private MySqlConnection cnx;

        private ConnexionSql() 
        {
            this.cnx = new MySqlConnection(Properties.Settings.Default.Database1ConnectionString);
        }

        public static ConnexionSql Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ConnexionSql();
                }
                    return instance;
            }
        }

        public MySqlConnection _Cnx
        {
            get
            {
                return Instance.cnx;
            }
        }

        public static void OpenConnexion()
        {
            try
            {
                Instance.cnx.Open();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CloseConnexion()
        {
            try
            {
                Instance.cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
