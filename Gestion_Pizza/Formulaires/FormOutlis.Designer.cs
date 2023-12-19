namespace Gestion_Pizza.Formulaires
{
    partial class FormOutlis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewOutils = new System.Windows.Forms.DataGridView();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.commandeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutils)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOutils
            // 
            this.dataGridViewOutils.AllowUserToAddRows = false;
            this.dataGridViewOutils.AllowUserToDeleteRows = false;
            this.dataGridViewOutils.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOutils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commandeID,
            this.dateCommande});
            this.dataGridViewOutils.Location = new System.Drawing.Point(42, 164);
            this.dataGridViewOutils.Name = "dataGridViewOutils";
            this.dataGridViewOutils.ReadOnly = true;
            this.dataGridViewOutils.Size = new System.Drawing.Size(721, 252);
            this.dataGridViewOutils.TabIndex = 0;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(42, 65);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(192, 40);
            this.buttonRechercher.TabIndex = 0;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date minimum de la commande";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(296, 26);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 9;
            // 
            // commandeID
            // 
            this.commandeID.HeaderText = "ID de la commande trouvé";
            this.commandeID.Name = "commandeID";
            this.commandeID.ReadOnly = true;
            // 
            // dateCommande
            // 
            this.dateCommande.HeaderText = "Date de la commande";
            this.dateCommande.Name = "dateCommande";
            this.dateCommande.ReadOnly = true;
            // 
            // FormOutlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOutils);
            this.Name = "FormOutlis";
            this.Text = "FormOutlis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutils)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOutils;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCommande;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}