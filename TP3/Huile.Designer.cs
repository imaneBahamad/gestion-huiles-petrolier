namespace TP3
{
    partial class Huile
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
            this.ajouter_btn = new System.Windows.Forms.Button();
            this.trier_btn = new System.Windows.Forms.Button();
            this.lister_btn = new System.Windows.Forms.Button();
            this.exception_lbl = new System.Windows.Forms.Label();
            this.total_btn = new System.Windows.Forms.Button();
            this.fournisseur_txt = new System.Windows.Forms.TextBox();
            this.total_lbl = new System.Windows.Forms.Label();
            this.rupture_btn = new System.Windows.Forms.Button();
            this.maxVF_btn = new System.Windows.Forms.Button();
            this.maxVC_btn = new System.Windows.Forms.Button();
            this.viscositeMax_btn = new System.Windows.Forms.Button();
            this.supprimer_btn = new System.Windows.Forms.Button();
            this.destockage_btn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.nom_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vf_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vc_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petrolier_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ajouter_btn
            // 
            this.ajouter_btn.BackColor = System.Drawing.Color.White;
            this.ajouter_btn.FlatAppearance.BorderSize = 2;
            this.ajouter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.ajouter_btn.Location = new System.Drawing.Point(25, 10);
            this.ajouter_btn.Name = "ajouter_btn";
            this.ajouter_btn.Size = new System.Drawing.Size(125, 47);
            this.ajouter_btn.TabIndex = 1;
            this.ajouter_btn.Text = "Ajouter";
            this.ajouter_btn.UseVisualStyleBackColor = false;
            this.ajouter_btn.Click += new System.EventHandler(this.ajouter_btn_Click);
            // 
            // trier_btn
            // 
            this.trier_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.trier_btn.FlatAppearance.BorderSize = 0;
            this.trier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trier_btn.ForeColor = System.Drawing.Color.White;
            this.trier_btn.Location = new System.Drawing.Point(206, 43);
            this.trier_btn.Name = "trier_btn";
            this.trier_btn.Size = new System.Drawing.Size(152, 60);
            this.trier_btn.TabIndex = 4;
            this.trier_btn.Text = "Trier par stock";
            this.trier_btn.UseVisualStyleBackColor = false;
            this.trier_btn.Click += new System.EventHandler(this.trier_btn_Click);
            // 
            // lister_btn
            // 
            this.lister_btn.BackColor = System.Drawing.Color.White;
            this.lister_btn.FlatAppearance.BorderSize = 2;
            this.lister_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lister_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lister_btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.lister_btn.Location = new System.Drawing.Point(25, 114);
            this.lister_btn.Name = "lister_btn";
            this.lister_btn.Size = new System.Drawing.Size(125, 47);
            this.lister_btn.TabIndex = 3;
            this.lister_btn.Text = "Lister";
            this.lister_btn.UseVisualStyleBackColor = false;
            this.lister_btn.Click += new System.EventHandler(this.lister_btn_Click);
            // 
            // exception_lbl
            // 
            this.exception_lbl.BackColor = System.Drawing.Color.Transparent;
            this.exception_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exception_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.exception_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exception_lbl.Location = new System.Drawing.Point(25, 175);
            this.exception_lbl.Name = "exception_lbl";
            this.exception_lbl.Size = new System.Drawing.Size(943, 25);
            this.exception_lbl.TabIndex = 5;
            // 
            // total_btn
            // 
            this.total_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.total_btn.FlatAppearance.BorderSize = 0;
            this.total_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.total_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_btn.ForeColor = System.Drawing.Color.White;
            this.total_btn.Location = new System.Drawing.Point(242, 518);
            this.total_btn.Name = "total_btn";
            this.total_btn.Size = new System.Drawing.Size(93, 34);
            this.total_btn.TabIndex = 12;
            this.total_btn.Text = "Total";
            this.total_btn.UseVisualStyleBackColor = false;
            this.total_btn.Click += new System.EventHandler(this.total_btn_Click);
            // 
            // fournisseur_txt
            // 
            this.fournisseur_txt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fournisseur_txt.Location = new System.Drawing.Point(25, 524);
            this.fournisseur_txt.Name = "fournisseur_txt";
            this.fournisseur_txt.Size = new System.Drawing.Size(209, 22);
            this.fournisseur_txt.TabIndex = 11;
            this.fournisseur_txt.Text = "Pétrolier";
            this.fournisseur_txt.Enter += new System.EventHandler(this.fournisseur_txt_Enter);
            // 
            // total_lbl
            // 
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(362, 525);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(606, 23);
            this.total_lbl.TabIndex = 8;
            // 
            // rupture_btn
            // 
            this.rupture_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.rupture_btn.FlatAppearance.BorderSize = 0;
            this.rupture_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rupture_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rupture_btn.ForeColor = System.Drawing.Color.White;
            this.rupture_btn.Location = new System.Drawing.Point(402, 43);
            this.rupture_btn.Name = "rupture_btn";
            this.rupture_btn.Size = new System.Drawing.Size(184, 60);
            this.rupture_btn.TabIndex = 5;
            this.rupture_btn.Text = "Huiles en rupture de stock";
            this.rupture_btn.UseVisualStyleBackColor = false;
            this.rupture_btn.Click += new System.EventHandler(this.rupture_btn_Click);
            // 
            // maxVF_btn
            // 
            this.maxVF_btn.BackColor = System.Drawing.Color.White;
            this.maxVF_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.maxVF_btn.FlatAppearance.BorderSize = 2;
            this.maxVF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxVF_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxVF_btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.maxVF_btn.Location = new System.Drawing.Point(838, 10);
            this.maxVF_btn.Name = "maxVF_btn";
            this.maxVF_btn.Size = new System.Drawing.Size(129, 41);
            this.maxVF_btn.TabIndex = 7;
            this.maxVF_btn.Text = "Max VF";
            this.maxVF_btn.UseVisualStyleBackColor = false;
            this.maxVF_btn.Click += new System.EventHandler(this.maxVF_btn_Click);
            // 
            // maxVC_btn
            // 
            this.maxVC_btn.BackColor = System.Drawing.Color.White;
            this.maxVC_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.maxVC_btn.FlatAppearance.BorderSize = 2;
            this.maxVC_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxVC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxVC_btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.maxVC_btn.Location = new System.Drawing.Point(838, 54);
            this.maxVC_btn.Name = "maxVC_btn";
            this.maxVC_btn.Size = new System.Drawing.Size(129, 41);
            this.maxVC_btn.TabIndex = 8;
            this.maxVC_btn.Text = "Max VC";
            this.maxVC_btn.UseVisualStyleBackColor = false;
            this.maxVC_btn.Click += new System.EventHandler(this.maxVC_btn_Click);
            // 
            // viscositeMax_btn
            // 
            this.viscositeMax_btn.BackColor = System.Drawing.Color.White;
            this.viscositeMax_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.viscositeMax_btn.FlatAppearance.BorderSize = 2;
            this.viscositeMax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viscositeMax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viscositeMax_btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.viscositeMax_btn.Location = new System.Drawing.Point(838, 98);
            this.viscositeMax_btn.Name = "viscositeMax_btn";
            this.viscositeMax_btn.Size = new System.Drawing.Size(129, 63);
            this.viscositeMax_btn.TabIndex = 9;
            this.viscositeMax_btn.Text = "Viscosité maximum";
            this.viscositeMax_btn.UseVisualStyleBackColor = false;
            this.viscositeMax_btn.Click += new System.EventHandler(this.viscositeMax_btn_Click);
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.BackColor = System.Drawing.Color.White;
            this.supprimer_btn.FlatAppearance.BorderSize = 2;
            this.supprimer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.supprimer_btn.Location = new System.Drawing.Point(25, 62);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(125, 47);
            this.supprimer_btn.TabIndex = 2;
            this.supprimer_btn.Text = "Supprimer";
            this.supprimer_btn.UseVisualStyleBackColor = false;
            this.supprimer_btn.Click += new System.EventHandler(this.supprimer_btn_Click);
            // 
            // destockage_btn
            // 
            this.destockage_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.destockage_btn.FlatAppearance.BorderSize = 0;
            this.destockage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destockage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destockage_btn.ForeColor = System.Drawing.Color.White;
            this.destockage_btn.Location = new System.Drawing.Point(631, 43);
            this.destockage_btn.Name = "destockage_btn";
            this.destockage_btn.Size = new System.Drawing.Size(152, 60);
            this.destockage_btn.TabIndex = 6;
            this.destockage_btn.Text = "Déstockage";
            this.destockage_btn.UseVisualStyleBackColor = false;
            this.destockage_btn.Click += new System.EventHandler(this.destockage_btn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_data,
            this.vf_data,
            this.vc_data,
            this.prix_data,
            this.stock_data,
            this.petrolier_data});
            this.dataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid.Location = new System.Drawing.Point(25, 205);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(943, 303);
            this.dataGrid.TabIndex = 10;
            // 
            // nom_data
            // 
            this.nom_data.HeaderText = "Nom";
            this.nom_data.MinimumWidth = 6;
            this.nom_data.Name = "nom_data";
            // 
            // vf_data
            // 
            this.vf_data.HeaderText = "VF";
            this.vf_data.MinimumWidth = 6;
            this.vf_data.Name = "vf_data";
            // 
            // vc_data
            // 
            this.vc_data.HeaderText = "VC";
            this.vc_data.MinimumWidth = 6;
            this.vc_data.Name = "vc_data";
            // 
            // prix_data
            // 
            this.prix_data.HeaderText = "Prix";
            this.prix_data.MinimumWidth = 6;
            this.prix_data.Name = "prix_data";
            // 
            // stock_data
            // 
            this.stock_data.HeaderText = "Stock";
            this.stock_data.MinimumWidth = 6;
            this.stock_data.Name = "stock_data";
            // 
            // petrolier_data
            // 
            this.petrolier_data.HeaderText = "Petrolier";
            this.petrolier_data.MinimumWidth = 6;
            this.petrolier_data.Name = "petrolier_data";
            // 
            // Huile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 568);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.destockage_btn);
            this.Controls.Add(this.supprimer_btn);
            this.Controls.Add(this.viscositeMax_btn);
            this.Controls.Add(this.maxVC_btn);
            this.Controls.Add(this.maxVF_btn);
            this.Controls.Add(this.rupture_btn);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.fournisseur_txt);
            this.Controls.Add(this.total_btn);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.lister_btn);
            this.Controls.Add(this.trier_btn);
            this.Controls.Add(this.ajouter_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Huile";
            this.Text = "Gestion de stock des huiles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter_btn;
        private System.Windows.Forms.Button trier_btn;
        private System.Windows.Forms.Button lister_btn;
        private System.Windows.Forms.Label exception_lbl;
        private System.Windows.Forms.Button total_btn;
        private System.Windows.Forms.TextBox fournisseur_txt;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Button rupture_btn;
        private System.Windows.Forms.Button maxVF_btn;
        private System.Windows.Forms.Button maxVC_btn;
        private System.Windows.Forms.Button viscositeMax_btn;
        private System.Windows.Forms.Button supprimer_btn;
        private System.Windows.Forms.Button destockage_btn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn vf_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn vc_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn petrolier_data;
    }
}

