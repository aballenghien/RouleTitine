using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALConducteur
    {
        
        public static bool insert(Conducteur conducteur)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();            
            requete.Transaction = trx;
            requete.CommandText = "INSERT INTO Conducteur(nom, prenom, motDePasse,mail,identifiant)" 
                +"VALUES (@nom,@prenom,@motDePasse,@mail,@identifiant)";
            requete.Parameters.AddWithValue("@nom",conducteur._Nom);
            requete.Parameters.AddWithValue("@prenom", conducteur._Prenom);
            requete.Parameters.AddWithValue("@motDePasse", conducteur._Password);
            requete.Parameters.AddWithValue("@mail", conducteur._Mail);
            requete.Parameters.AddWithValue("@identifiant", conducteur._Identifiant);
            int nbEnregistrementsAffectes = 0;
            try
            {
                nbEnregistrementsAffectes =(int) requete.ExecuteNonQuery();
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

        public static bool delete(Conducteur conducteur)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM Conducteur WHERE identifiant = @id";
            requete.Parameters.AddWithValue("@id", conducteur._Identifiant);
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

        public static Conducteur getConducteurByIdentifiant(string id)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT nom, prenom, motDePasse, mail, identifiant FROM Conducteur WHERE identifiant=@id;";
            requete.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = requete.ExecuteReader();
            Conducteur conduct = new Conducteur();
            while (reader.Read())
            {
                conduct._Nom = reader["nom"].ToString();
                conduct._Prenom = reader["prenom"].ToString();
                conduct._Password =  (byte[])reader["motDePasse"];
                conduct._Mail = reader["mail"].ToString();
                conduct._Identifiant = reader["identifiant"].ToString();
            }
            ConnexionSql.CloseConnexion();
            return conduct;

        }
        
    }
}
