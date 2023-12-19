namespace Gestion_Pizza.Formulaires
{
    partial class FormCommande
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
            this.dataGridViewCommande = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRecharger = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDP = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownQuantite = new System.Windows.Forms.NumericUpDown();
            this.commandeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unePizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommande)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCommande
            // 
            this.dataGridViewCommande.AllowUserToAddRows = false;
            this.dataGridViewCommande.AllowUserToDeleteRows = false;
            this.dataGridViewCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commandeID,
            this.quantite,
            this.dateCommande,
            this.unePizza});
            this.dataGridViewCommande.Location = new System.Drawing.Point(32, 198);
            this.dataGridViewCommande.Name = "dataGridViewCommande";
            this.dataGridViewCommande.Size = new System.Drawing.Size(735, 222);
            this.dataGridViewCommande.TabIndex = 0;
            this.dataGridViewCommande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCommande_CellClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(187, 33);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(183, 20);
            this.textBoxID.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRecharger);
            this.groupBox1.Controls.Add(this.buttonModifier);
            this.groupBox1.Location = new System.Drawing.Point(441, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 133);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations";
            // 
            // buttonRecharger
            // 
            this.buttonRecharger.Location = new System.Drawing.Point(25, 76);
            this.buttonRecharger.Name = "buttonRecharger";
            this.buttonRecharger.Size = new System.Drawing.Size(168, 31);
            this.buttonRecharger.TabIndex = 2;
            this.buttonRecharger.Text = "Liste";
            this.buttonRecharger.UseVisualStyleBackColor = true;
            this.buttonRecharger.Click += new System.EventHandler(this.buttonRecharger_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(25, 31);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(168, 31);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantité de pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date de la commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID de la commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID de la pizza";
            // 
            // textBoxIDP
            // 
            this.textBoxIDP.Location = new System.Drawing.Point(187, 147);
            this.textBoxIDP.Name = "textBoxIDP";
            this.textBoxIDP.Size = new System.Drawing.Size(183, 20);
            this.textBoxIDP.TabIndex = 16;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(187, 68);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerDate.TabIndex = 17;
            // 
            // numericUpDownQuantite
            // 
            this.numericUpDownQuantite.Location = new System.Drawing.Point(187, 110);
            this.numericUpDownQuantite.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownQuantite.Name = "numericUpDownQuantite";
            this.numericUpDownQuantite.Size = new System.Drawing.Size(183, 20);
            this.numericUpDownQuantite.TabIndex = 18;
            // 
            // commandeID
            // 
            this.commandeID.HeaderText = "ID de la commande";
            this.commandeID.Name = "commandeID";
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            // 
            // dateCommande
            // 
            this.dateCommande.HeaderText = "Date de la commande";
            this.dateCommande.Name = "dateCommande";
            // 
            // unePizza
            // 
            this.unePizza.HeaderText = "Type de pizza";
            this.unePizza.Name = "unePizza";
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownQuantite);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxIDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCommande);
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommande)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCommande;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDP;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantite;
        private System.Windows.Forms.Button buttonRecharger;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn unePizza;
    }
}