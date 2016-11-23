using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALEntretienAFaire
    {

        public static long insert(EntretienAFaire entretien)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();
            requete.Transaction = trx;
            requete.CommandText = "INSERT INTO EntretienAFaire(entretien,modele)"
                + "VALUES (@entretien, @modele)";
            requete.Parameters.AddWithValue("@entretien", entretien._EntretienRegulier._Id);
            requete.Parameters.AddWithValue("@modele", entretien._Modele._Id);
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

        public static bool delete(EntretienAFaire ent)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM EntretienAFaire WHERE id = @id";
            requete.Parameters.AddWithValue("@id", ent._Id);
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

        public static List<EntretienAFaire> getEntretienAFaireByModele(Modele mod)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT id,entretien,modele FROM entretienafaire WHERE modele = @id";
            requete.Parameters.AddWithValue("@id", mod._Id);
            MySqlDataReader reader = requete.ExecuteReader();
            List<EntretienAFaire> lstent = new List<EntretienAFaire>();
            while (reader.Read())
            {
                EntretienAFaire ent = new EntretienAFaire();
                ent._Id = (int)reader["id"];
                ent._Modele = mod;
                ent._EntretienRegulier._Id = (long)reader["entretien"];
                lstent.Add(ent);
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            foreach (EntretienAFaire e in lstent)
            {
                e._EntretienRegulier = DALEntretienRegulier.getEntretienById(e._EntretienRegulier._Id);
            }
            return lstent;

        }

       

    }
}
