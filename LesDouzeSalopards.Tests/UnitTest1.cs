using LesDouzeSalopards.Business;
using LesDouzeSalopards.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LesDouzeSalopards.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void realisation_contrats_vérifie_la_bonne_prime_condamné_vivant()
        {
            // SetUp
            List<Condamné> listeCondamnés = new List<Condamné>();
            var newCondamné = new Condamné();
            newCondamné.EtatCondamné = EtatCondamné.Vivant;
            listeCondamnés.Add(newCondamné);
            RègleRéalisationContrat règleRéalisationContrat = new RègleRéalisationContrat(listeCondamnés, null);


            // Exercice
            Prime prime = new Prime();
            prime = règleRéalisationContrat.CalculePrime(prime);

            // Verify
            Assert.AreEqual(prime.Montant, Constants.ValeurCondamnéVivant);
        }

        [TestMethod]
        public void calcule_de_la_prime_apres_majoration_existe_vivant()
        {
            // SetUp
            List<Condamné> listeCondamnés = new List<Condamné>();
            var newCondamnéA = new Condamné();
            newCondamnéA.EtatCondamné = EtatCondamné.Vivant;
            listeCondamnés.Add(newCondamnéA);

            var newCondamnéB = new Condamné();
            newCondamnéB.EtatCondamné = EtatCondamné.Mort;
            listeCondamnés.Add(newCondamnéB);
            Prime prime = new Prime();

            var majorationAucunvivant = new MajorationAucunVivant(listeCondamnés, null);
            prime = majorationAucunvivant.CalculePrime(new Prime() { Montant = Constants.ValeurCondamnéVivant + Constants.ValeurCondamnéMort});

            // Verify
            decimal exptectedResult = Constants.ValeurCondamnéVivant + Constants.ValeurCondamnéMort;
            Assert.AreEqual(exptectedResult, prime.Montant);

        }

        [TestMethod]
        public void calcule_de_la_prime_apres_majoration_aucun_vivant()
        {
            // SetUp
            List<Condamné> listeCondamnés = new List<Condamné>();
            var newCondamnéA = new Condamné();
            newCondamnéA.EtatCondamné = EtatCondamné.Mort;
            listeCondamnés.Add(newCondamnéA);

            var newCondamnéB = new Condamné();
            newCondamnéB.EtatCondamné = EtatCondamné.Mort;
            listeCondamnés.Add(newCondamnéB);

            Prime prime = new Prime();
            //var règleRéalisationContrat = new RègleRéalisationContrat(listeCondamnés);
            //var majorationAucunvivant = new MajorationAucunVivant(listeCondamnés);
            //var regles = new List<IRègle>() { règleRéalisationContrat, majorationAucunvivant };

            ////Exercice:
            //foreach(var regle in regles)
            //{
            //    prime = regle.CalculePrime(prime);
            //}

            var majorationAucunvivant = new MajorationAucunVivant(listeCondamnés, null);
            prime = majorationAucunvivant.CalculePrime(new Prime() { Montant= Constants.ValeurCondamnéMort * 2 });

            //Verify:
            decimal exptectedResult = Constants.ValeurCondamnéMort * 2;
            exptectedResult = exptectedResult * (100 + Constants.PourcentageAucunVivant) / 100;
            Assert.AreEqual(exptectedResult, prime.Montant);

        }

        [TestMethod]
        public void calcule_de_la_prime_apres_majoration_nombre_de_condamné_quand_majoration_aucun_vivant_est_satisfaite()
        {
            // SetUp
            List<Condamné> listeCondamnés = new List<Condamné>();
            var newCondamnéA = new Condamné();
            newCondamnéA.EtatCondamné = EtatCondamné.Mort;
            listeCondamnés.Add(newCondamnéA);
            var newCondamnéB = new Condamné();
            newCondamnéB.EtatCondamné = EtatCondamné.Mort;
            listeCondamnés.Add(newCondamnéB);


            Prime prime = new Prime();
            var majorationAucunvivant = new MajorationAucunVivant(listeCondamnés, null);
            prime = majorationAucunvivant.CalculePrime(new Prime() { Montant = Constants.ValeurCondamnéMort * 2 });

            // Exercice: 
            var majorationNombreDeCondamné = new MajorationNombreCondamnés(listeCondamnés, majorationAucunvivant);
            prime = majorationNombreDeCondamné.CalculePrime(prime);

            //Verify:
            decimal exptectedResult = Constants.ValeurCondamnéMort * 2;
            exptectedResult = exptectedResult * (100 + Constants.PourcentageAucunVivant) / 100;
            Assert.AreEqual(exptectedResult, prime.Montant);

        }

        [TestMethod]
        public void calcule_de_la_prime_apres_majoration_nombre_de_condamné_quand_majoration_aucun_vivant_non_satisfaite()
        {
            // SetUp
            List<Condamné> listeCondamnés = new List<Condamné>();
            var newCondamnéA = new Condamné();
            newCondamnéA.EtatCondamné = EtatCondamné.Mort;
            listeCondamnés.Add(newCondamnéA);
            var newCondamnéB = new Condamné();
            newCondamnéB.EtatCondamné = EtatCondamné.Vivant;
            listeCondamnés.Add(newCondamnéB);


            Prime prime = new Prime();
            var majorationAucunvivant = new MajorationAucunVivant(listeCondamnés, null);
            prime = majorationAucunvivant.CalculePrime(new Prime() {Montant = Constants.ValeurCondamnéVivant + Constants.ValeurCondamnéMort});

            // Exercice: 
            var majorationNombreDeCondamné = new MajorationNombreCondamnés(listeCondamnés, majorationAucunvivant);
            prime = majorationNombreDeCondamné.CalculePrime(prime);

            //Verify:
            decimal exptectedResult = Constants.ValeurCondamnéVivant + Constants.ValeurCondamnéMort;
            exptectedResult = exptectedResult * Constants.TrancheDeMajoration[2] / 100;
            Assert.AreEqual(exptectedResult, prime.Montant);

        }

        [TestMethod]
        public void calcule_de_la_prime_apres_majoration_budget_max()
        {
            // SetUp
            Prime prime = new Prime();
            prime.Montant = Constants.BudgetMax - 200;


            // Exercice: 
            var majorationBudgetMax = new MajorationBudgetMax();
            prime = majorationBudgetMax.CalculePrime(prime);

            //Verify:
            decimal exptectedResult = Constants.BudgetMax - 200;
            Assert.AreEqual(exptectedResult, prime.Montant);

        }

    }
}
