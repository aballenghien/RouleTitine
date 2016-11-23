using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionVoiture
{
    public class DALVoiture
    {

        public static bool insert(Voiture voiture)
        {
            ConnexionSql.OpenConnexion();
            MySqlTransaction trx = ConnexionSql.Instance._Cnx.BeginTransaction();
            MySqlCommand requete = ConnexionSql.Instance._Cnx.CreateCommand();
            requete.Transaction = trx;
            requete.CommandText = "INSERT INTO Voiture(immatriculation, image, dateAchat, dateMiseEnCirculation, kilometrage, volumeReservoir, carburant, modele, conducteur)"
                + "VALUES (@immat, @img, @dtAchat, @dtMiseEnCircu, @km, @vReserv, @carbu, @mod, @conduct)";
            requete.Parameters.AddWithValue("@immat", voiture._Immatriculation);
            requete.Parameters.AddWithValue("@img", voiture._Image);
            requete.Parameters.AddWithValue("@dtAchat", voiture._DateAchat);
            requete.Parameters.AddWithValue("@dtMiseEnCircu", voiture._DateMiseEnCirculation);
            requete.Parameters.AddWithValue("@km", voiture._Kilometrage);
            requete.Parameters.AddWithValue("@vReserv", voiture._VolumeReservoir);
            requete.Parameters.AddWithValue("@carbu", voiture._Carburant._Nom);
            requete.Parameters.AddWithValue("@mod", voiture._Modele._Id);
            requete.Parameters.AddWithValue("@conduct", voiture._Conducteur._Id);
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

        public static bool delete(Voiture voiture)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "DELETE FROM Voiture WHERE immatriculation = @immat";
            requete.Parameters.AddWithValue("@immat", voiture._Immatriculation);
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

        public static List<Voiture> getVoituresByConducteur(Conducteur c)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT immatriculation, image, dateAchat, dateMiseEnCirculation, dateVente, kilometrage,"
            + "volumeReservoir, carburant, modele, conducteur FROM Voiture" 
            +" WHERE conducteur = @id;";
            requete.Parameters.AddWithValue("@id", c._Id);
            MySqlDataReader reader = requete.ExecuteReader();
            List<Voiture> lstVoiture = new List<Voiture>();
            while (reader.Read())
            {
                Voiture v = new Voiture();
                v._Immatriculation = reader["immatriculation"].ToString();
                v._Image = (byte[])reader["image"];
                v._Conducteur = c;
                v._DateAchat =(DateTime) reader["dateAchat"];
                v._DateMiseEnCirculation = (DateTime)reader["dateMiseEnCirculation"];
                if(!(reader["dateVente"]).Equals(System.DBNull.Value)){
                    v._DateVente = (DateTime)reader["dateVente"];
                }
                v._Kilometrage = (int)reader["kilometrage"];
                v._VolumeReservoir = (int)reader["volumeReservoir"];
                Carburant car = new Carburant();
                car._Nom = reader["carburant"].ToString();
                v._Carburant = car;
                v._Modele = new Modele();
                v._Modele._Id = (int)reader["modele"];
                v._Conducteur._Id = (int)reader["conducteur"];
                lstVoiture.Add(v);
            }
            reader.Close();
            foreach(Voiture elem in lstVoiture){
                elem._Modele = DALModele.getModeleById(elem._Modele._Id);
                elem._Conducteur = DALConducteur.getConducteurById(elem._Conducteur._Id);
            }
            ConnexionSql.CloseConnexion();
            return lstVoiture;

        }

        public static bool updateDateVente(Voiture voit)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "UPDATE voiture SET dateVente = @datevente WHERE immatriculation = @immat";
            requete.Parameters.AddWithValue("@datevente", voit._DateVente);
            requete.Parameters.AddWithValue("@immat", voit._Immatriculation);
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

        public static Voiture getVoitureByImmatriculation(string immat)
        {
            MySqlCommand requete = new MySqlCommand();
            requete.Connection = ConnexionSql.Instance._Cnx;
            ConnexionSql.OpenConnexion();
            requete.CommandText = "SELECT immatriculation, image, dateAchat, dateMiseEnCirculation, dateVente, kilometrage,"
            + "volumeReservoir, carburant, modele, conducteur FROM Voiture"
            + " WHERE immatriculation = @immat";
            requete.Parameters.AddWithValue("@immat", immat);
            MySqlDataReader reader = requete.ExecuteReader();
            Voiture v = new Voiture();
            while (reader.Read())
            {
                v._Immatriculation = reader["immatriculation"].ToString();
                v._Image = (byte[])reader["image"];
                v._Conducteur._Id = (int)reader["conducteur"];
                v._DateAchat = (DateTime)reader["dateAchat"];
                v._DateMiseEnCirculation = (DateTime)reader["dateMiseEnCirculation"];
                if (!(reader["dateVente"]).Equals(System.DBNull.Value))
                {
                    v._DateVente = (DateTime)reader["dateVente"];
                }
                v._Kilometrage = (int)reader["kilometrage"];
                v._VolumeReservoir = (int)reader["volumeReservoir"];
                Carburant car = new Carburant();
                car._Nom = reader["carburant"].ToString();
                v._Carburant = car;
                v._Modele = new Modele();
                v._Modele._Id = (int)reader["modele"];
                v._Conducteur = new Conducteur();
                v._Conducteur._Id = (int)reader["conducteur"];
            }
            reader.Close();            
            v._Conducteur = DALConducteur.getConducteurById(v._Conducteur._Id);
            v._Modele = DALModele.getModeleById(v._Modele._Id);
            ConnexionSql.CloseConnexion();
            return v;

        }

    }
}
