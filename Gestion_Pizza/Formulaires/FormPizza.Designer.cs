namespace Gestion_Pizza.Formulaires
{
    partial class FormPizza
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
            this.dataGridViewPizza = new System.Windows.Forms.DataGridView();
            this.PizzaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixPizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRecharger = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.numericUpDownPrix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizza)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPizza
            // 
            this.dataGridViewPizza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PizzaID,
            this.typePizza,
            this.prixPizza});
            this.dataGridViewPizza.Location = new System.Drawing.Point(36, 169);
            this.dataGridViewPizza.Name = "dataGridViewPizza";
            this.dataGridViewPizza.ReadOnly = true;
            this.dataGridViewPizza.Size = new System.Drawing.Size(722, 255);
            this.dataGridViewPizza.TabIndex = 0;
            this.dataGridViewPizza.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPizza_CellClick);
            // 
            // PizzaID
            // 
            this.PizzaID.HeaderText = "ID de la pizza";
            this.PizzaID.Name = "PizzaID";
            this.PizzaID.ReadOnly = true;
            // 
            // typePizza
            // 
            this.typePizza.HeaderText = "Type de la pizza";
            this.typePizza.Name = "typePizza";
            this.typePizza.ReadOnly = true;
            // 
            // prixPizza
            // 
            this.prixPizza.HeaderText = "Prix de la pizza";
            this.prixPizza.Name = "prixPizza";
            this.prixPizza.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID de la pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type de la pizza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prix de la pizza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRecharger);
            this.groupBox1.Controls.Add(this.buttonSupprimer);
            this.groupBox1.Controls.Add(this.buttonAjouter);
            this.groupBox1.Location = new System.Drawing.Point(338, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations";
            // 
            // buttonRecharger
            // 
            this.buttonRecharger.Location = new System.Drawing.Point(210, 23);
            this.buttonRecharger.Name = "buttonRecharger";
            this.buttonRecharger.Size = new System.Drawing.Size(168, 31);
            this.buttonRecharger.TabIndex = 2;
            this.buttonRecharger.Text = "Liste des pizzas";
            this.buttonRecharger.UseVisualStyleBackColor = true;
            this.buttonRecharger.Click += new System.EventHandler(this.buttonRecharger_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(25, 66);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(168, 31);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(25, 23);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(168, 31);
            this.buttonAjouter.TabIndex = 0;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(152, 21);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(141, 20);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(152, 63);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(141, 20);
            this.textBoxType.TabIndex = 6;
            // 
            // numericUpDownPrix
            // 
            this.numericUpDownPrix.Location = new System.Drawing.Point(152, 107);
            this.numericUpDownPrix.Name = "numericUpDownPrix";
            this.numericUpDownPrix.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownPrix.TabIndex = 7;
            // 
            // FormPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownPrix);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPizza);
            this.Name = "FormPizza";
            this.Text = "FormPizza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizza)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn PizzaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button buttonRecharger;
        private System.Windows.Forms.NumericUpDown numericUpDownPrix;
    }
}