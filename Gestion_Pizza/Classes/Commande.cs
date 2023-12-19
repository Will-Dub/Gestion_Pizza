using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Gestion_Pizza.Classes
{
    public class Commande
    {
        //Attributs privé
        private string commandeID;
        private DateTime dateCommande;
        private int quantite;
        private Pizza unePizza;

        // Propriétés
        public string CommandeID {
            get { return commandeID; }
            set {
                if (value.Length == 6 && Regex.IsMatch(value, "[A-Za-z]{1}[0-9]{5}$"))
                {
                    this.commandeID = value;
                }
            }
        }
        public DateTime DateCommande { get { return dateCommande; } set { dateCommande = value; } }
        public int Quantite { 
            get { return quantite; }
            set {
                if(value > 0)
                {
                    this.quantite = value;
                }
            }}

        public Pizza UnePizza {
            get { return unePizza; }
            set { this.unePizza = value; }
        }

        // Constructeur
        public Commande(string p_commandeId = "000000", DateTime p_dateCommane = default(DateTime), int p_quantite = -1)
        {
            this.commandeID = p_commandeId;
            this.dateCommande = p_dateCommane;
            this.quantite = p_quantite;
        }

        //Méthodes
        /// <summary>
        /// Calcul le prix total de la commande avec taxes
        /// </summary>
        /// <returns></returns>
        public float calculer_prix_commande()
        {
            if(UnePizza != null)
            {
                float prix = quantite * unePizza.PrixPizza;
                prix = prix * (float)(9.975 + 5);
                return prix;
            }
            return 0;
        }


    }
}
