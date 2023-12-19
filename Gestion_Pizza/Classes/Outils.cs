using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pizza.Classes
{
    public static class Outils
    {
        // Attribut privé
        private static List<Commande> list_commandes = new List<Commande>();
        private static List<Pizza> list_pizza = new List<Pizza>();

        //Propriété
        public static List<Pizza> List_pizza
        {
            get { return list_pizza; }
            set { list_pizza = value; }
        }

        public static List<Commande> List_commandes
        {
            get { return list_commandes; }
            set { list_commandes = value; }
        }

        // Méthodes
        public static List<Commande> chercher_commande(int p_quantite)
        {
            List<Commande> liste_commande_valide = new List<Commande>();
            foreach(Commande commande in list_commandes)
            {
                if(commande.Quantite > p_quantite)
                {
                    liste_commande_valide.Add(commande);
                }
            }
            return liste_commande_valide;
        }

    }
}
