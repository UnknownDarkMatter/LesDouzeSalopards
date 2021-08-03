
namespace LesDouzeSalopards
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnCalculePrime = new System.Windows.Forms.Button();
            this.txbPrime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Etat});
            this.dataGridView1.Location = new System.Drawing.Point(56, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Etat condamné";
            this.Etat.Items.AddRange(new object[] {
            "Vivant",
            "Mort"});
            this.Etat.MinimumWidth = 6;
            this.Etat.Name = "Etat";
            this.Etat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Etat.Width = 200;
            // 
            // btnCalculePrime
            // 
            this.btnCalculePrime.Location = new System.Drawing.Point(610, 64);
            this.btnCalculePrime.Name = "btnCalculePrime";
            this.btnCalculePrime.Size = new System.Drawing.Size(163, 48);
            this.btnCalculePrime.TabIndex = 1;
            this.btnCalculePrime.Text = "Calculer la prime";
            this.btnCalculePrime.UseVisualStyleBackColor = true;
            this.btnCalculePrime.Click += new System.EventHandler(this.btnCalculePrime_Click);
            // 
            // txbPrime
            // 
            this.txbPrime.Location = new System.Drawing.Point(610, 196);
            this.txbPrime.Name = "txbPrime";
            this.txbPrime.Size = new System.Drawing.Size(151, 22);
            this.txbPrime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPrime);
            this.Controls.Add(this.btnCalculePrime);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewComboBoxColumn Etat;
        private System.Windows.Forms.Button btnCalculePrime;
        private System.Windows.Forms.TextBox txbPrime;
        private System.Windows.Forms.Label label1;
    }
}

