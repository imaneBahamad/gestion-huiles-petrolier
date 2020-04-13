using System;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        //////////Events

        private void reinitialiser_btn_Click(object sender, EventArgs e)
        {
            nom_txt.Text = "";
            vf_combo.Text = "0";
            vc_combo.Text = "30";
            prix_txt.Text = "";
            stock_txt.Text = "";
            petrolier_txt.Text = "";
        }

        private void valider_btn_Click(object sender, EventArgs e)
        {
            string nom = nom_txt.Text;
            int vf = Convert.ToInt32(vf_combo.SelectedItem), vc = Convert.ToInt32(vc_combo.SelectedItem);
            double prix = Convert.ToDouble(prix_txt.Text);
            int stock = Convert.ToInt32(stock_txt.Text);
            string petrolier = petrolier_txt.Text;
            Huile huile = new Huile(nom, vf, vc, prix, stock, petrolier);
            try
            {
                Program.Menu("Ajouter", huile);
                message_lbl.Text = "Huile ajouté avec succés";
            }catch(Exception exp)
            {
                message_lbl.Text = "Oups Il y a un problème";
            }


            reinitialiser_btn_Click(sender,e);
        }

    }
}
