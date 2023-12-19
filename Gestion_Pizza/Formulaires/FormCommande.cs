using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Gestion_Pizza.Formulaires
{
    public partial class FormCommande : Form
    {

        //Déclarations
        SqlConnection cnx;
        SqlCommand command;
        SqlDataReader resultat;
        int position = -1;

        public FormCommande()
        {
            InitializeComponent();
        }

        private void FormCommande_Load(object sender, EventArgs e)
        {
            using (cnx = new SqlConnection())
            {
                //Met a jour le datagrid view

                //Setup la conncection et la commande
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                command = new SqlCommand("Select * from Commandes", cnx);

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
                            dataGridViewCommande.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3]);
                        }
                    }
                    else
                        MessageBox.Show("La table Commande est vide.");
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
        }

        private void buttonRecharger_Click(object sender, EventArgs e)
        {
            //Enleve les donné de la datagridview
            dataGridViewCommande.Rows.Clear();
            //Recharge la datagrid view
            FormCommande_Load(sender, e);

            textBoxID.Select();
            textBoxID.Focus();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            using (cnx = new SqlConnection())
            {
                //Setup la connection et la commande
                int quantite_t = int.Parse(numericUpDownQuantite.Value.ToString());
                DateTime date_t = dateTimePickerDate.Value;
                string commandeID_t = textBoxID.Text;
                string pizzaID_t = textBoxIDP.Text;

                Classes.Commande commande_temp = new Classes.Commande();
                commande_temp.CommandeID = commandeID_t;
                commande_temp.DateCommande = date_t;
                commande_temp.Quantite = quantite_t;

                foreach (Classes.Pizza pizza in Classes.Outils.List_pizza)
                {
                    if (pizza.PizzaID == pizzaID_t)
                    {
                        commande_temp.UnePizza = pizza;
                    }
                }

                if (commande_temp.CommandeID == commandeID_t && commande_temp.DateCommande == date_t && commande_temp.Quantite == quantite_t)
                {
                    cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                    command.Connection = cnx;
                    command.CommandText = "UPDATE Commandes SET Nb_Pizzas=@PNb, Date_Commande=@PDate, PizzaID=@PPID where CommandesID=@PID";
                    command.Parameters.AddWithValue("@PNb", quantite_t);
                    command.Parameters.AddWithValue("@PDate", date_t);
                    command.Parameters.AddWithValue("@PPID", pizzaID_t);
                    command.Parameters.AddWithValue("@PID", commandeID_t);

                    try
                    {
                        cnx.Open();
                        int nombreLignes = command.ExecuteNonQuery();
                        if (nombreLignes != 1)
                            MessageBox.Show("Erreur", "Erreur...");
                        cnx.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur");
                    }
                    finally
                    {
                        buttonRecharger_Click(sender, e);
                        // reinitialiser les textBox
                        numericUpDownQuantite.Value = 0;
                        textBoxID.Text = "";
                        textBoxIDP.Text = "";
                        cnx.Close();
                    }
                }

            }
        }

        private void dataGridViewCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = dataGridViewCommande.CurrentRow.Index;
            if (dataGridViewCommande.RowCount - 1 != 0)
            {
                this.textBoxID.Text = dataGridViewCommande.Rows[position].Cells[0].Value.ToString();
                this.numericUpDownQuantite.Value = int.Parse(dataGridViewCommande.Rows[position].Cells[1].Value.ToString());
                //this.dateTimePickerDate.Value = DateTime.Parse(dataGridViewCommande.Rows[position].Cells[1].Value.ToString());
                this.textBoxIDP.Text = dataGridViewCommande.Rows[position].Cells[3].Value.ToString();
            }
        }
    }
}
