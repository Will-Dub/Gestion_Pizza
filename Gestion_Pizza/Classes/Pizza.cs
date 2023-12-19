using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Gestion_Pizza.Classes
{
    public class Pizza
    {
        // Attributs privés
        private string pizzaID;
        private string typePizza;
        private int prixPizza;

        // Propriétés
        public string PizzaID {
            get { return pizzaID; }
            set {
                if(Regex.IsMatch(value, "[0-9]{3}"))
                {
                    this.pizzaID = value;
                }
            }
        }

        public string TypePizza {
            get { return typePizza; }
            set {
                if(value == "Neapolitan Pizza" || value == "Chicago Pizza" || value == "Greek Pizza")
                {
                    this.typePizza = value;
                }
            } 
        }

        public int PrixPizza {
            get { return prixPizza; }
            set {
                if(value >= 0)
                {
                    this.prixPizza = value;
                }
            }
        }

        //Méthode
        public Pizza(string p_pizzald="!", string p_typePizza="!", int p_prixPizza=0)
        {
            this.pizzaID = p_pizzald;
            this.typePizza = p_typePizza;
            this.prixPizza = p_prixPizza;
        }
    }
}
