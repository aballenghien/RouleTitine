using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALEntretienFait
    {

        public static long insert(EntretienFait entretien)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();
            requete.Transaction = trx;
            requete.CommandText = "INSERT INTO EntretienFait(date,kilometrage,commentaire,voiture,garage,"
                + "entretienRegulier,entretienPonctuel,prix) "
                + "VALUES (@date,@kilometrage,@commentaire,@voiture,@garage,@entretienR,@entretienP,@prix)";

            requete.Parameters.AddWithValue("@date", entretien._Date);
            requete.Parameters.AddWithValue("@kilometrage", entretien._Kilometrage);
            requete.Parameters.AddWithValue("@voiture", entretien._Voiture._Immatriculation);
            requete.Parameters.AddWithValue("@commentaire", entretien._Commentaire);
            requete.Parameters.AddWithValue("@garage", entretien._Garage._Id);
            requete.Parameters.AddWithValue("@prix", entretien._Prix);
            if (entretien._TypeEntretien.Equals("R"))
            {
                requete.Parameters.AddWithValue("@entretienR", entretien._Entretien._Id);
                requete.Parameters.AddWithValue("@entretienP",null);
            }
            else
            {
                requete.Parameters.AddWithValue("@entretienP", entretien._Entretien._Id);
                requete.Parameters.AddWithValue("@entretienR", null);
            }

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

        public static bool delete(EntretienFait ent)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM EntretienFait WHERE id = @id";
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

        public static List<EntretienFait> getEntretienAFaireByVoiture(Voiture v)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT id,date,kilometrage,commentaire,voiture,garage,"
                + "entretienRegulier,entretienPonctuel,prix" 
                +" FROM entretienfait WHERE voiture = @id"
                +" ORDER BY date";
            requete.Parameters.AddWithValue("@id", v._Immatriculation);
            MySqlDataReader reader = requete.ExecuteReader();
            List<EntretienFait> lstent = new List<EntretienFait>();
            while (reader.Read())
            {
                EntretienFait ent = new EntretienFait();
                ent._Id = (int)reader["id"];
                ent._Date = (DateTime)reader["date"];
                ent._Kilometrage = (int)reader["kilometrage"];
                ent._Commentaire = reader["commentaire"].ToString();
                ent._Voiture = v;
                ent._Garage._Id = (int)reader["garage"];
                ent._Prix = (decimal)reader["prix"];
                if (reader["entretienRegulier"].ToString().Equals(""))
                {
                    ent._TypeEntretien = "P";
                    ent._Entretien._Id = (long)reader["entretienPonctuel"];
                }
                else
                {
                    ent._TypeEntretien = "R";
                    ent._Entretien._Id = (long)reader["entretienRegulier"];
                }
                lstent.Add(ent);
            }
            reader.Close();
            ConnexionSql.CloseConnexion();
            foreach (EntretienFait e in lstent)
            {
                if (e._TypeEntretien.Equals("R"))
                {
                    e._Entretien = DALEntretienRegulier.getEntretienById(e._Entretien._Id);
                }
                else
                {
                    e._Entretien = DALEntretienPonctuel.getEntretienById(e._Entretien._Id);
                }
                e._Garage = DALGarage.getGarageById(e._Garage._Id);
            }
            return lstent;

        }



    }
}
