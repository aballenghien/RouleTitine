using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionVoiture;
using System.Security.Cryptography;
namespace UnitTestGestionVoiture
{
    [TestClass]
    public class ConducteurTest
    {
       [TestMethod]
        public void methode_test_enregistrerNouveauConducteur()
        {
            Conducteur c = new Conducteur();
            c._Nom = "Ballenghien";
            c._Prenom = "Audrey";
            c._Mail = "audrey.ballenghien@gmail.com";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes("aballenghien");
            SHA1 sha = new SHA1CryptoServiceProvider();
            c._Password = sha.ComputeHash(bytes);
            c._Identifiant = "aballenghi";
            Assert.AreEqual(true, Conducteur.EnregistrerNouveauConducteur(c));
        }
    }
}
