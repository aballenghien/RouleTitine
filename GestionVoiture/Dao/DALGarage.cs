using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALGarage
    {

        public static long insert(Garage garage)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();
            requete.Transaction = trx;
            requete.CommandText = "INSERT INTO garage(nom,adresse,codepostal,ville,telephone)"
                + "VALUES (@nom,@adresse,@codepostal,@ville,@telephone)";
            requete.Parameters.AddWithValue("@nom", garage._Nom);
            requete.Parameters.AddWithValue("@adresse", garage._Adresse);
            requete.Parameters.AddWithValue("@codepostal", garage._CodePostal);
            requete.Parameters.AddWithValue("@ville", garage._Ville);
            requete.Parameters.AddWithValue("@telephone", garage._Telephone);
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
                return requete.LastInsertedId;
            }
            else
            {
                return -1;
            }

        }

        public static bool delete(Garage garage)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM Marque WHERE id = @id";
            requete.Parameters.AddWithValue("@id", garage._Id);
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


        public static List<Garage> getAllGarages()
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT id, nom, adresse, codepostal, ville, telephone FROM Garage";
            MySqlDataReader reader = requete.ExecuteReader();
            List<Garage> lstGarage = new List<Garage>();
            while (reader.Read())
            {
                Garage g = new Garage();
                g._Id = (int)reader["id"];
                g._Nom = reader["nom"].ToString();
                g._Adresse = reader["adresse"].ToString();
                g._Ville = reader["ville"].ToString();
                g._CodePostal = reader["codepostal"].ToString();
                g._Telephone = reader["telephone"].ToString();
                lstGarage.Add(g);
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            return lstGarage;

        }

        public static Garage getGarageById(int idGarage)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT id, nom, adresse, codepostal, ville, telephone FROM Garage WHERE id = @id";
            requete.Parameters.AddWithValue("@id", idGarage);
            MySqlDataReader reader = requete.ExecuteReader();
            Garage g = new Garage();
            while (reader.Read())
            {
                g._Id = idGarage;
                g._Nom = reader["nom"].ToString();
                g._Adresse = reader["adresse"].ToString();
                g._Ville = reader["ville"].ToString();
                g._CodePostal = reader["codepostal"].ToString();
                g._Telephone = reader["telephone"].ToString();
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            return g;

        }



    }
}
