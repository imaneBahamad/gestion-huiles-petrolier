using System;
using System.Windows.Forms;

namespace TP3
{
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }

        //////////Events

        private void valider_btn_Click(object sender, EventArgs e)
        {
            int vf = Convert.ToInt32(vf_combo.Text), vc = Convert.ToInt32(vc_combo.Text);
           
            message_lbl.Text = (string) Program.Menu("Supprimer",vf,vc);
            reinitialiser_btn_Click(sender, e);
        }

        private void reinitialiser_btn_Click(object sender, EventArgs e)
        {
            vf_combo.Text = "0";
            vc_combo.Text = "30";
        }
    }
}
