namespace TP3
{
    partial class Ajouter
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
            this.nom_lbl = new System.Windows.Forms.Label();
            this.vf_lbl = new System.Windows.Forms.Label();
            this.vc_lbl = new System.Windows.Forms.Label();
            this.prix_lbl = new System.Windows.Forms.Label();
            this.stock_lbl = new System.Windows.Forms.Label();
            this.petrolier_lbl = new System.Windows.Forms.Label();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.prix_txt = new System.Windows.Forms.TextBox();
            this.petrolier_txt = new System.Windows.Forms.TextBox();
            this.stock_txt = new System.Windows.Forms.TextBox();
            this.vf_combo = new System.Windows.Forms.ComboBox();
            this.vc_combo = new System.Windows.Forms.ComboBox();
            this.valider_btn = new System.Windows.Forms.Button();
            this.reinitialiser_btn = new System.Windows.Forms.Button();
            this.message_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nom_lbl
            // 
            this.nom_lbl.AutoSize = true;
            this.nom_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_lbl.Location = new System.Drawing.Point(112, 65);
            this.nom_lbl.Name = "nom_lbl";
            this.nom_lbl.Size = new System.Drawing.Size(37, 17);
            this.nom_lbl.TabIndex = 0;
            this.nom_lbl.Text = "Nom";
            // 
            // vf_lbl
            // 
            this.vf_lbl.AutoSize = true;
            this.vf_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vf_lbl.Location = new System.Drawing.Point(112, 114);
            this.vf_lbl.Name = "vf_lbl";
            this.vf_lbl.Size = new System.Drawing.Size(139, 17);
            this.vf_lbl.TabIndex = 1;
            this.vf_lbl.Text = "Viscosité à froid (VF)";
            // 
            // vc_lbl
            // 
            this.vc_lbl.AutoSize = true;
            this.vc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vc_lbl.Location = new System.Drawing.Point(112, 162);
            this.vc_lbl.Name = "vc_lbl";
            this.vc_lbl.Size = new System.Drawing.Size(151, 17);
            this.vc_lbl.TabIndex = 2;
            this.vc_lbl.Text = "Viscosité à chaud (VC)";
            // 
            // prix_lbl
            // 
            this.prix_lbl.AutoSize = true;
            this.prix_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_lbl.Location = new System.Drawing.Point(112, 213);
            this.prix_lbl.Name = "prix_lbl";
            this.prix_lbl.Size = new System.Drawing.Size(31, 17);
            this.prix_lbl.TabIndex = 3;
            this.prix_lbl.Text = "Prix";
            // 
            // stock_lbl
            // 
            this.stock_lbl.AutoSize = true;
            this.stock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_lbl.Location = new System.Drawing.Point(112, 263);
            this.stock_lbl.Name = "stock_lbl";
            this.stock_lbl.Size = new System.Drawing.Size(43, 17);
            this.stock_lbl.TabIndex = 4;
            this.stock_lbl.Text = "Stock";
            // 
            // petrolier_lbl
            // 
            this.petrolier_lbl.AutoSize = true;
            this.petrolier_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrolier_lbl.Location = new System.Drawing.Point(112, 313);
            this.petrolier_lbl.Name = "petrolier_lbl";
            this.petrolier_lbl.Size = new System.Drawing.Size(61, 17);
            this.petrolier_lbl.TabIndex = 5;
            this.petrolier_lbl.Text = "Pétrolier";
            // 
            // nom_txt
            // 
            this.nom_txt.Location = new System.Drawing.Point(314, 65);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(365, 22);
            this.nom_txt.TabIndex = 1;
            // 
            // prix_txt
            // 
            this.prix_txt.Location = new System.Drawing.Point(314, 213);
            this.prix_txt.Name = "prix_txt";
            this.prix_txt.Size = new System.Drawing.Size(365, 22);
            this.prix_txt.TabIndex = 4;
            // 
            // petrolier_txt
            // 
            this.petrolier_txt.Location = new System.Drawing.Point(314, 313);
            this.petrolier_txt.Name = "petrolier_txt";
            this.petrolier_txt.Size = new System.Drawing.Size(365, 22);
            this.petrolier_txt.TabIndex = 6;
            // 
            // stock_txt
            // 
            this.stock_txt.Location = new System.Drawing.Point(314, 263);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.Size = new System.Drawing.Size(365, 22);
            this.stock_txt.TabIndex = 5;
            // 
            // vf_combo
            // 
            this.vf_combo.FormattingEnabled = true;
            this.vf_combo.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20"});
            this.vf_combo.Location = new System.Drawing.Point(314, 114);
            this.vf_combo.Name = "vf_combo";
            this.vf_combo.Size = new System.Drawing.Size(166, 24);
            this.vf_combo.TabIndex = 2;
            // 
            // vc_combo
            // 
            this.vc_combo.FormattingEnabled = true;
            this.vc_combo.Items.AddRange(new object[] {
            "30",
            "40",
            "50"});
            this.vc_combo.Location = new System.Drawing.Point(314, 162);
            this.vc_combo.Name = "vc_combo";
            this.vc_combo.Size = new System.Drawing.Size(166, 24);
            this.vc_combo.TabIndex = 3;
            // 
            // valider_btn
            // 
            this.valider_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.valider_btn.FlatAppearance.BorderSize = 0;
            this.valider_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valider_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider_btn.ForeColor = System.Drawing.Color.White;
            this.valider_btn.Location = new System.Drawing.Point(234, 378);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(138, 44);
            this.valider_btn.TabIndex = 7;
            this.valider_btn.Text = "Valider";
            this.valider_btn.UseVisualStyleBackColor = false;
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // reinitialiser_btn
            // 
            this.reinitialiser_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.reinitialiser_btn.FlatAppearance.BorderSize = 0;
            this.reinitialiser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinitialiser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reinitialiser_btn.ForeColor = System.Drawing.Color.White;
            this.reinitialiser_btn.Location = new System.Drawing.Point(427, 378);
            this.reinitialiser_btn.Name = "reinitialiser_btn";
            this.reinitialiser_btn.Size = new System.Drawing.Size(138, 44);
            this.reinitialiser_btn.TabIndex = 8;
            this.reinitialiser_btn.Text = "Réinitialiser";
            this.reinitialiser_btn.UseVisualStyleBackColor = false;
            this.reinitialiser_btn.Click += new System.EventHandler(this.reinitialiser_btn_Click);
            // 
            // message_lbl
            // 
            this.message_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_lbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.message_lbl.Location = new System.Drawing.Point(42, 13);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(462, 35);
            this.message_lbl.TabIndex = 15;
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message_lbl);
            this.Controls.Add(this.reinitialiser_btn);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.vc_combo);
            this.Controls.Add(this.vf_combo);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.petrolier_txt);
            this.Controls.Add(this.prix_txt);
            this.Controls.Add(this.nom_txt);
            this.Controls.Add(this.petrolier_lbl);
            this.Controls.Add(this.stock_lbl);
            this.Controls.Add(this.prix_lbl);
            this.Controls.Add(this.vc_lbl);
            this.Controls.Add(this.vf_lbl);
            this.Controls.Add(this.nom_lbl);
            this.MaximizeBox = false;
            this.Name = "Ajouter";
            this.Text = "Ajouter huile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom_lbl;
        private System.Windows.Forms.Label vf_lbl;
        private System.Windows.Forms.Label vc_lbl;
        private System.Windows.Forms.Label prix_lbl;
        private System.Windows.Forms.Label stock_lbl;
        private System.Windows.Forms.Label petrolier_lbl;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.TextBox prix_txt;
        private System.Windows.Forms.TextBox petrolier_txt;
        private System.Windows.Forms.TextBox stock_txt;
        private System.Windows.Forms.ComboBox vf_combo;
        private System.Windows.Forms.ComboBox vc_combo;
        private System.Windows.Forms.Button valider_btn;
        private System.Windows.Forms.Button reinitialiser_btn;
        private System.Windows.Forms.Label message_lbl;
    }
}