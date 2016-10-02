using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALMarque
    {

        public static bool insert(Marque marque)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();
            marque._Nom = marque._Nom.ToUpper();
            requete.Transaction = trx;
            requete.CommandText = "INSERT INTO Marque(nom)"
                + "VALUES (@nom)";
            requete.Parameters.AddWithValue("@nom", marque._Nom);
            int nbEnregistrementsAffectes = 0;
            try
            {
                nbEnregistrementsAffectes = (int)requete.ExecuteNonQuery();
                requete.Transaction.Commit();
            }
            catch
            {
                nbEnregistrementsAffectes = 0;
                requete.Transaction.Rollback();
            }
            ConnexionSql.CloseConnexion();
            if (nbEnregistrementsAffectes > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool delete(Marque marque)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM Marque WHERE nom = @nom";
            requete.Parameters.AddWithValue("@nom", marque._Nom);
            int nbEnregistrementsAffectes = requete.ExecuteNonQuery();
            ConnexionSql.CloseConnexion();
            if (nbEnregistrementsAffectes > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static List<Marque> getAllMarques()
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT nom FROM Marque";
            MySqlDataReader reader = requete.ExecuteReader();
            List<Marque> lstMarque = new List<Marque>();            
            while (reader.Read())
            {
                Marque marq = new Marque();
                marq._Nom = reader["nom"].ToString();
                lstMarque.Add(marq);
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            return lstMarque;

        }



    }
}
