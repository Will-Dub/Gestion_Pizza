using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Gestion_Pizza.Formulaires
{
    public partial class FormPizza : Form
    {

        //Déclarations
        SqlConnection cnx;
        SqlCommand command;
        SqlDataReader resultat;
        int position = -1;
  

        public FormPizza()
        {
            InitializeComponent();
        }

        private void FormPizza_Load(object sender, EventArgs e)
        {
            using(cnx = new SqlConnection())
            {
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                command = new SqlCommand("Select * from Pizzas", cnx);

                try
                {
                    cnx.Open();
                    //Résultat
                    resultat = command.ExecuteReader();
                    //resultat est une table avec des lignes et des colonnes
                    //On va boucler sur cette table

                    if (resultat.HasRows) //On vérifie si la table n'est pas vide
                    {
                        while (resultat.Read()) // Tant qu'il y a des lignes à lire
                        {
                            dataGridViewPizza.Rows.Add(resultat[0], resultat[1], resultat[2]);
                        }
                    }
                    else
                        MessageBox.Show("La table Pizza est vide.");
                        resultat.Close();
                }
                catch (Exception ex)
                {
                    //Erreur
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cnx.Close();
                }
            }

            textBoxID.Select();
            textBoxID.Focus();
        }

        private void buttonRecharger_Click(object sender, EventArgs e)
        {
            //Enlever les données du datagridview
            dataGridViewPizza.Rows.Clear();

            //Met les valeurs de la base de données
            FormPizza_Load(sender, e);

            textBoxID.Select();
            textBoxID.Focus();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            using (cnx = new SqlConnection())
            {
                string pizzaID = textBoxID.Text.Trim();
                int prixPizza = int.Parse(numericUpDownPrix.Value.ToString());
                string typePizza = textBoxType.Text.Trim();

                Classes.Pizza tempPizza = new Classes.Pizza();
                tempPizza.PizzaID = pizzaID;
                tempPizza.PrixPizza = prixPizza;
                tempPizza.TypePizza = typePizza;

                if (tempPizza.PizzaID == pizzaID && tempPizza.PrixPizza == prixPizza && tempPizza.TypePizza == typePizza)
                {
                    //Set up la connection et la commande
                    cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                    command.Connection = cnx;
                    command.CommandText = "INSERT INTO Pizzas (PizzaID,Type_Pizza,Prix_Pizza) values (@Pid,@Ptype,@Pprix);";
                    command.Parameters.AddWithValue("@Pid", pizzaID);
                    command.Parameters.AddWithValue("@Pprix", prixPizza);
                    command.Parameters.AddWithValue("@Ptype", typePizza);

                    try
                    {
                        //Execute la commande
                        cnx.Open();
                        int nombreLignes = command.ExecuteNonQuery();
                        if (nombreLignes != 1)
                            MessageBox.Show("Erreur", "Erreur...");
                        cnx.Close();
                        Classes.Outils.List_pizza.Add(tempPizza);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur");
                    }
                    finally
                    {
                        buttonRecharger_Click(sender, e);
                        // reinitialiser les textBox
                        textBoxID.Text = "";
                        textBoxType.Text = "";
                        numericUpDownPrix.Value = 0;
                        cnx.Close();
                    }
                }
                else
                {
                    //Messages d'erreurs
                    if(tempPizza.PizzaID != pizzaID)
                    {
                        MessageBox.Show("ID de la pizza invalide");
                    }
                    else if(tempPizza.PrixPizza != prixPizza)
                    {
                        MessageBox.Show("Prix de la pizza invalide");
                    }
                    else if(tempPizza.TypePizza != typePizza)
                    {
                        MessageBox.Show("Type de la pizza invalide");
                    }
                }

            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            using (cnx = new SqlConnection())
            {
                //Set up la connection et la commande
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                cnx.Open();
                SqlCommand commande = new SqlCommand();
                commande.Connection = cnx;
                string pizzaID = textBoxID.Text.Trim();
                commande.CommandText = "Delete From Pizzas where PizzaID=@PID";
                commande.Parameters.AddWithValue("@PID", pizzaID);

                //Demande l'utilisateur son choix
                DialogResult dialogresult = MessageBox.Show("Voulez-vous supprimer la pizza?", "Confirmation", MessageBoxButtons.YesNo);
                //Si il répond oui
                if (dialogresult == DialogResult.Yes)
                {
                    //Rétablir la connexion avec le serveur si elle est fermée   
                    try
                    {
                        commande.ExecuteNonQuery();
                        // Réinitialiser les textBoxs
                        textBoxID.Text = "";
                        numericUpDownPrix.Value = 0;
                        textBoxType.Text = "";
                        buttonRecharger_Click(sender, e);
                        foreach (Classes.Pizza pizza in Classes.Outils.List_pizza)
                        {
                            if (pizza.PizzaID == pizzaID)
                            {
                                Classes.Outils.List_pizza.Remove(pizza);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("La pizza à été choisi dans une commande");
                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
            }
        }

        private void dataGridViewPizza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cherche la postion du curseur
            position = dataGridViewPizza.CurrentRow.Index;
            //Change les données
            if (dataGridViewPizza.RowCount - 1 != 0)
            {
                this.textBoxID.Text = dataGridViewPizza.Rows[position].Cells[0].Value.ToString();
                this.textBoxType.Text = dataGridViewPizza.Rows[position].Cells[1].Value.ToString();
                this.numericUpDownPrix.Value = int.Parse(dataGridViewPizza.Rows[position].Cells[2].Value.ToString());
            }
        }
    }
}
