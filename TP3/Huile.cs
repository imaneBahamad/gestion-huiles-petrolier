using System;
using System.Collections;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Huile : Form
    {
        private String nom;
        private int vf, vc;
        private double prix;
        private int stock;
        private String petrolier;

        //////////Constructors
        public Huile()
        {
            InitializeComponent();

            this.nom = null;
            this.petrolier = null;
            this.vf = 0;
            this.vc = 0;
            this.prix = 0;
            this.stock = 0;
            object objet = Program.RestaurerT1();
            if (objet.GetType() == typeof(string[])) {
                remplirDataGrid((string[]) objet);
            }
            else
            {
                exception_lbl.Text = (string)objet;
            }
        }

        public Huile(String nom,int vf,int vc,double prix,int stock,String petrolier)
        {
            this.nom = nom;
            this.vf = vf;
            this.vc = vc;
            this.prix = prix;
            this.stock = stock;
            this.petrolier = petrolier;
        }

        //////////Getters & setters

        public String GetNom()
        {
            return nom;
        }

        public void SetNom(String nom)
        {
            this.nom = nom;
        }

        public int GetVf()
        {
            return vf;
        }

        public void SetVf(int vf)
        {
            this.vf=vf;
        }

        public int GetVc()
        {
            return vc;
        }

        public void SetVc(int vc)
        {
            this.vc = vc;
        }

        public double GetPrix()
        {
            return prix;
        }

        public void SetPrix(double prix)
        {
            this.prix = prix;
        }

        public int GetStock()
        {
            return stock;
        }

        public void GetStock(int stock)
        {
            this.stock = stock;
        }


        public String GetPetrolier()
        {
            return petrolier;
        }

        public void SetPetrolier(String petrolier)
        {
            this.petrolier = petrolier;
        }

        //////////Méthods

        public override string ToString()
        {
            return nom + "-" + vf + "-" + vc + "-" + prix + "-" + stock + "-" + petrolier;
        }

        public void remplirDataGrid(string[] text)
        {
            dataGrid.Rows.Clear();
            foreach (string line in text)
            {
                string[] columns = line.Split('-');
                dataGrid.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4], columns[5]);
            }
        }

        public async void listerArraylist(ArrayList list, string message)
        {
            if (list.Count == 0)
            {
                exception_lbl.Text = message;
                await Task.Delay(5000);
                exception_lbl.Text = "";
                return;
            }
            dataGrid.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string[] data = (list[i].ToString()).Split('-');
                dataGrid.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5]);
            }
        }

        //////////Events

        private void ajouter_btn_Click(object sender, EventArgs e)
        {
            Ajouter ajouter = new Ajouter();
            ajouter.Show();
        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            Supprimer supprimer = new Supprimer();
            supprimer.Show();
        }

        private void lister_btn_Click(object sender, EventArgs e)
        {
            remplirDataGrid((string[])Program.Menu("Lister"));
        }

        private void trier_btn_Click(object sender, EventArgs e)
        {
            remplirDataGrid((string[])Program.Menu("Trier"));
        }

        private void rupture_btn_Click(object sender, EventArgs e)
        {
            listerArraylist((ArrayList)Program.Menu("Rupture"), "Pas d'huile en rupture de stock!");
        }

        private void maxVF_btn_Click(object sender, EventArgs e)
        {
            listerArraylist((ArrayList)Program.Menu("MaxVF"), "Pas d'huile avec une VF maximum (20)!");
        }

        private void maxVC_btn_Click(object sender, EventArgs e)
        {
            listerArraylist((ArrayList)Program.Menu("MaxVC"), "Pas d'huile avec une VC maximum (50)!");
        }

        private void viscositeMax_btn_Click(object sender, EventArgs e)
        {
            listerArraylist((ArrayList)Program.Menu("ViscositéMax"), "Pas d'huile avec une viscosité maximum!");
        }

        private void destockage_btn_Click(object sender, EventArgs e)
        {
            listerArraylist((ArrayList)Program.Menu("Déstockage"), "Aucun bidon d'huile disponible pour déstockage!"); 
        }

        private void total_btn_Click(object sender, EventArgs e)
        {
            double total = (double) Program.Menu("Total",fournisseur_txt.Text);
            if (total== 0)
            {
                total_lbl.Text = "Ce fournisseur n'existe pas!";
                return;
            }

            total_lbl.Text = "Prix des bidons d'huile disponibles : " + total + " DHs";
        }

        private void fournisseur_txt_Enter(object sender, EventArgs e)
        {
            if (fournisseur_txt.Text == "Pétrolier")
            {
                fournisseur_txt.Text = "";
                fournisseur_txt.ForeColor = Color.Black;
            }
        }




    }
}
