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
        String Query;
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
                Query = "Select * from Pizzas";
                command = new SqlCommand(Query, cnx);

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
            dataGridViewPizza.Rows.Clear();
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
                    cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                    command.Connection = cnx;
                    command.CommandText = "INSERT INTO Pizzas (PizzaID,Type_Pizza,Prix_Pizza) values (@Pid,@Ptype,@Pprix);";
                    command.Parameters.AddWithValue("@Pid", pizzaID);
                    command.Parameters.AddWithValue("@Pprix", prixPizza);
                    command.Parameters.AddWithValue("@Ptype", typePizza);

                    try
                    {
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
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                cnx.Open();
                SqlCommand commande = new SqlCommand();
                commande.Connection = cnx;
                string pizzaID = textBoxID.Text.Trim();
                commande.CommandText = "Delete From Pizzas where PizzaID=@PID";
                commande.Parameters.AddWithValue("@PID", pizzaID);

                DialogResult dialogresult = MessageBox.Show("Voulez-vous supprimer la pizza?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    //Rétablir la connexion avec le serveur si elle est fermée   
                    commande.ExecuteNonQuery();
                        
                    cnx.Close();
                    // Réinitialiser les textBoxs
                    textBoxID.Text = "";
                    numericUpDownPrix.Value = 0;
                    textBoxType.Text = "";
                    buttonRecharger_Click(sender, e);
                    foreach(Classes.Pizza pizza in Classes.Outils.List_pizza)
                    {
                        if(pizza.PizzaID == pizzaID)
                        {
                            Classes.Outils.List_pizza.Remove(pizza);
                        }
                    }
                }
            }
        }

        private void dataGridViewPizza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = dataGridViewPizza.CurrentRow.Index;
            if (dataGridViewPizza.RowCount - 1 != 0)
            {
                this.textBoxID.Text = dataGridViewPizza.Rows[position].Cells[0].Value.ToString();
                this.numericUpDownPrix.Value = int.Parse(dataGridViewPizza.Rows[position].Cells[1].Value.ToString());
                this.textBoxType.Text = dataGridViewPizza.Rows[position].Cells[2].Value.ToString();
            }
        }
    }
}
