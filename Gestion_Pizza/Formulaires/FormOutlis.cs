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
    public partial class FormOutlis : Form
    {

        //Déclarations
        SqlConnection cnx;
        SqlCommand command;
        SqlDataReader resultat;

        public FormOutlis()
        {
            InitializeComponent();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            //Réinitialise le dataGridView
            dataGridViewOutils.Rows.Clear();

            using (cnx = new SqlConnection())
            {
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                command = new SqlCommand();
                command.Connection = cnx;
                command.CommandText = "exec obtenir_commandes_apres_date @PDate";
                command.Parameters.AddWithValue("@PDate", dateTimePickerDate.Value);

                try
                {
                    cnx.Open();
                    resultat = command.ExecuteReader();
                    //resultat est une table avec des lignes et des colonnes
                    //On va boucler sur cette table

                    if (resultat.HasRows) //Vérifie si la table n'est pas vide
                    {
                        while (resultat.Read()) // Tant qu'il y a des lignes à lire
                        {
                            dataGridViewOutils.Rows.Add(resultat[0], resultat[2]);
                        }
                    }
                    else
                        MessageBox.Show("Aucune valeur trouvé.");
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
    }
}
