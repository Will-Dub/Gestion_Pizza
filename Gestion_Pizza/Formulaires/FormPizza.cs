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
        int NumeroEtud = -1;
        bool check = false;

        public FormPizza()
        {
            InitializeComponent();
        }

        public void FormPizza_Load(object sender, EventArgs e)
        {
            using(cnx = new SqlConnection())
            {
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                Query = "Select * from Etudiant";
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
                    //Fermeture du DataReader
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

        private void buttonAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}
