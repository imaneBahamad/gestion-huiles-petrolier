namespace TP3
{
    partial class Supprimer
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
            this.vf_lbl = new System.Windows.Forms.Label();
            this.vc_lbl = new System.Windows.Forms.Label();
            this.valider_btn = new System.Windows.Forms.Button();
            this.reinitialiser_btn = new System.Windows.Forms.Button();
            this.message_lbl = new System.Windows.Forms.Label();
            this.vf_combo = new System.Windows.Forms.ComboBox();
            this.vc_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // vf_lbl
            // 
            this.vf_lbl.AutoSize = true;
            this.vf_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vf_lbl.Location = new System.Drawing.Point(85, 111);
            this.vf_lbl.Name = "vf_lbl";
            this.vf_lbl.Size = new System.Drawing.Size(25, 17);
            this.vf_lbl.TabIndex = 0;
            this.vf_lbl.Text = "VF";
            // 
            // vc_lbl
            // 
            this.vc_lbl.AutoSize = true;
            this.vc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vc_lbl.Location = new System.Drawing.Point(85, 181);
            this.vc_lbl.Name = "vc_lbl";
            this.vc_lbl.Size = new System.Drawing.Size(26, 17);
            this.vc_lbl.TabIndex = 1;
            this.vc_lbl.Text = "VC";
            // 
            // valider_btn
            // 
            this.valider_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.valider_btn.FlatAppearance.BorderSize = 0;
            this.valider_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valider_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider_btn.ForeColor = System.Drawing.Color.White;
            this.valider_btn.Location = new System.Drawing.Point(70, 287);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(144, 42);
            this.valider_btn.TabIndex = 3;
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
            this.reinitialiser_btn.Location = new System.Drawing.Point(239, 287);
            this.reinitialiser_btn.Name = "reinitialiser_btn";
            this.reinitialiser_btn.Size = new System.Drawing.Size(144, 42);
            this.reinitialiser_btn.TabIndex = 4;
            this.reinitialiser_btn.Text = "Réinitialiser";
            this.reinitialiser_btn.UseVisualStyleBackColor = false;
            this.reinitialiser_btn.Click += new System.EventHandler(this.reinitialiser_btn_Click);
            // 
            // message_lbl
            // 
            this.message_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_lbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.message_lbl.Location = new System.Drawing.Point(12, 28);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(378, 35);
            this.message_lbl.TabIndex = 6;
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
            this.vf_combo.Location = new System.Drawing.Point(140, 111);
            this.vf_combo.Name = "vf_combo";
            this.vf_combo.Size = new System.Drawing.Size(227, 24);
            this.vf_combo.TabIndex = 1;
            // 
            // vc_combo
            // 
            this.vc_combo.FormattingEnabled = true;
            this.vc_combo.Items.AddRange(new object[] {
            "30",
            "40",
            "50"});
            this.vc_combo.Location = new System.Drawing.Point(140, 181);
            this.vc_combo.Name = "vc_combo";
            this.vc_combo.Size = new System.Drawing.Size(227, 24);
            this.vc_combo.TabIndex = 2;
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 400);
            this.Controls.Add(this.vc_combo);
            this.Controls.Add(this.vf_combo);
            this.Controls.Add(this.message_lbl);
            this.Controls.Add(this.reinitialiser_btn);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.vc_lbl);
            this.Controls.Add(this.vf_lbl);
            this.MaximizeBox = false;
            this.Name = "Supprimer";
            this.Text = "Supprimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vf_lbl;
        private System.Windows.Forms.Label vc_lbl;
        private System.Windows.Forms.Button valider_btn;
        private System.Windows.Forms.Button reinitialiser_btn;
        private System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.ComboBox vf_combo;
        private System.Windows.Forms.ComboBox vc_combo;
    }
}