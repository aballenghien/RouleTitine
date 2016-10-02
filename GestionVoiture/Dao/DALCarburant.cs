using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALCarburant
    {

        public static bool insert(Carburant carburant)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();
            requete.Transaction = trx;
            carburant._Nom = carburant._Nom.ToUpper();
            requete.CommandText = "INSERT INTO Carburant(nom) "
                + "VALUES (@nom)";
            requete.Parameters.AddWithValue("@nom", carburant._Nom);
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

        public static bool delete(Carburant carburant)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM Carburant WHERE nom = @nom";
            requete.Parameters.AddWithValue("@nom", carburant._Nom);
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

        public static List<Carburant> getAllCarburant()
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT nom FROM Carburant";
            MySqlDataReader reader = requete.ExecuteReader();
            List<Carburant> lstcarb = new List<Carburant>();
            while (reader.Read())
            {
                Carburant carb = new Carburant();
                carb._Nom = reader["nom"].ToString();
                lstcarb.Add(carb);
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            return lstcarb;

        }        

    }
}
