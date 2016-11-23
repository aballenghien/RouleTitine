using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net.Mail;

namespace GestionVoiture
{
    public class Conducteur
    {
        private int id;
        private string nom;
        private string prenom;
        private decimal bonusMalus;
        private string identifiant;
        private byte[] password;
        private string mail;

        public int _Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public decimal _BonusMalus
        {
            get
            {
                return this.bonusMalus;
            }
            set
            {
                this.bonusMalus = value;
            }
        }

        public string _Identifiant
        {
            get
            {
                return this.identifiant;
            }
            set
            {
                this.identifiant = value;
            }
        }

        public string _Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        public string _Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string _Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.prenom = value;
            }
        }

        public byte[] _Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public static bool EnregistrerNouveauConducteur(Conducteur c)
        {
            bool enregistre = DALConducteur.insert(c);
            if (enregistre) 
            { 
                //try
                //{
                //    MailMessage mail = new MailMessage();
                //    SmtpClient client = new SmtpClient();
                //    mail.From = new MailAddress(Properties.Settings.Default.fromMail);
                //    mail.To.Add(c._Mail);
                //    mail.Subject = "Nouveau compte RouleTitine";
                //    mail.Body = "Bonjour "+c._Prenom +",\n"
                //        +"Vous pouvez maintenant vous connecter à l'application RouleTitine pour gérer l'entretien de votre voiture.\n"
                //        +"Votre identifiant est : "+c._Identifiant;
                //    client.Host = Properties.Settings.Default.hostMail;
                //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //    client.Port = Properties.Settings.Default.portMail;
                //    client.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.fromMail, Properties.Settings.Default.mdpMail);
                //    client.EnableSsl = true;

                //    client.Send(mail);
                    return true;
                //}
                //catch
                //{
                //    return false;   
                //}

            }else
            {
                return false;
            }
        }
    }


}
