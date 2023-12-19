using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pizza.Formulaires
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPizza formPizza = new FormPizza();
            formPizza.MdiParent = this;
            formPizza.Show();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCommande formCommande = new FormCommande();
            formCommande.MdiParent = this;
            formCommande.Show();
        }

        private void outilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOutlis formOutlis = new FormOutlis();
            formOutlis.MdiParent = this;
            formOutlis.Show();
        }
    }
}
