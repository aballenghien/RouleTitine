using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionVoiture;
using System.Security.Cryptography;
using System.Diagnostics;

namespace UnitTestGestionVoiture
{
    [TestClass]
    public class DALConducteurTest
    {
        [TestMethod]
        public void methode_test_insert() {
            Conducteur c = new Conducteur();
            c._Nom = "Ballenghien";
            c._Prenom = "Audrey";
            c._Mail = "audrey.ballenghien@gmail.com";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes("aballenghien");
            SHA1 sha = new SHA1CryptoServiceProvider();
            c._Password = sha.ComputeHash(bytes);
            c._Identifiant = "aballenghi";
            Assert.AreEqual(true, DALConducteur.insert(c));
        }

        [TestMethod]
        public void methode_test_getConducteurByIdentifiant()
        {
            Conducteur c = new Conducteur();
            c._Nom = "Ballenghien";
            c._Prenom = "Audrey";
            c._Mail = "audrey.ballenghien@gmail.com";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes("aballenghien");
            SHA1 sha = new SHA1CryptoServiceProvider();
            c._Password = sha.ComputeHash(bytes);
            c._Identifiant = "aballenghi";
            Conducteur ctrouve = DALConducteur.getConducteurByIdentifiant(c._Identifiant);
            Assert.AreEqual(ctrouve._Identifiant, c._Identifiant);
            Assert.AreEqual(ctrouve._Mail, c._Mail);
            Assert.AreEqual(ctrouve._Nom, c._Nom);
            CollectionAssert.AreEqual(ctrouve._Password, c._Password);
            Assert.AreEqual(ctrouve._Prenom, c._Prenom);
        }

        [TestMethod]
        public void methode_test_delete()
        {
            Conducteur c = new Conducteur();
            c._Identifiant = "aballenghi";
            Assert.AreEqual(true, DALConducteur.delete(c));
        }
    }
}
