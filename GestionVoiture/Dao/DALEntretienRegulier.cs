using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALEntretienRegulier
    {

        public static long insert(EntretienRegulier entretien)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();
            requete.Transaction = trx;
            requete.CommandText = "INSERT INTO EntretienRegulier(nom, kilometrage,nombreMois)"
                + "VALUES (@nom,@kilometrage,@nombreMois)";
            requete.Parameters.AddWithValue("@nom", entretien._Nom);
            requete.Parameters.AddWithValue("@kilometrage", entretien._Kilometrage);
            requete.Parameters.AddWithValue("@nombreMois", entretien._Periode);
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

        public static bool delete(EntretienRegulier entretien)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM EntretienRegulier WHERE id = @id";
            requete.Parameters.AddWithValue("@id", entretien._Id);
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

        public static EntretienRegulier getEntretienById(long id)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT id, nom, kilometrage, nombreMois FROM EntretienRegulier WHERE id = @id";
            requete.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = requete.ExecuteReader();
            EntretienRegulier ent = new EntretienRegulier();
            while (reader.Read())
            {
                ent._Id = (int)reader["id"];
                ent._Nom = reader["nom"].ToString();
                ent._Kilometrage = (int)reader["kilometrage"];
                ent._Periode = (int)reader["nombreMois"];
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            return ent;

        }

    }
}
