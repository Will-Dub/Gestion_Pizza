using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Gestion_Pizza_XUNIT.Models
{
    public class OutilsClassShould
    {
        public void ajout_commande(string p_commandeId, int p_quantite)
        {
            Gestion_Pizza.Classes.Commande commande = new Gestion_Pizza.Classes.Commande();
            commande.CommandeID = p_commandeId;
            commande.Quantite = p_quantite;
            Gestion_Pizza.Classes.Outils.List_commandes.Add(commande);
        }

        [Theory]
        [InlineData(1, 6)]
        [InlineData(2, 5)]
        [InlineData(9, 2)]
        [InlineData(10, 1)]
        [InlineData(100, 0)]
        public void chercher_commande_test(int p_quantite, int expected_number)
        {
            //Initialisation
            ajout_commande("A22221", 2);
            ajout_commande("A22222", 3);
            ajout_commande("A22223", 4);
            ajout_commande("A22224", 5);
            ajout_commande("A22225", 10);
            ajout_commande("A22225", 100);

            //Test unitaire
            int returned_number = Gestion_Pizza.Classes.Outils.chercher_commande(p_quantite).Count;

            Assert.Equal(expected_number, returned_number);

            //Enleve les éléments de la liste
            Gestion_Pizza.Classes.Outils.List_commandes.Clear();
        }

        

    }
}
