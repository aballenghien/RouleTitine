using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALModele
    {

        public static long insert(Modele modele)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();
            modele._Nom = modele._Nom.ToUpper();
            requete.Transaction = trx;
            requete.CommandText = "INSERT INTO Modele(nom, marque)"
                + "VALUES (@nom,@marque)";
            requete.Parameters.AddWithValue("@nom", modele._Nom);
            requete.Parameters.AddWithValue("@marque", modele._Marque._Nom);
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

        public static bool delete(Modele modele)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM Modele WHERE id = @id";
            requete.Parameters.AddWithValue("@id", modele._Id);
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

        public static Modele getModeleById(long id)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT nom, marque FROM Modele WHERE id=@id;";
            requete.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = requete.ExecuteReader();
            Modele mod = new Modele();
            while (reader.Read())
            {
                mod._Id = id;
                mod._Nom = reader["nom"].ToString();
                mod._Marque = new Marque(reader["marque"].ToString());
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            return mod;

        }



        public static List<Modele> getModelesByMarque(Marque marque)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT id,nom, marque FROM Modele WHERE marque=@marque;";
            requete.Parameters.AddWithValue("@marque", marque._Nom);
            MySqlDataReader reader = requete.ExecuteReader();
            List<Modele> lstModele = new List<Modele>();
            while (reader.Read())
            {
                Modele mod = new Modele();
                mod._Id = (int)reader["id"];
                mod._Nom = reader["nom"].ToString();
                mod._Marque = new Marque(reader["marque"].ToString());
                lstModele.Add(mod);
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            return lstModele;

        }

    }
}
