using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        private static ArrayList T1 = new ArrayList();

        public static void Saisie(Huile huile)
        {
            T1.Add(huile);
            SauvegarderT1();
        }

        public static string[] Liste()
        {
            List<string> text = new List<string>();
            if (T1.Count != 0)
            {
                for (int i = 0; i < T1.Count; i++)
                {
                    text.Add(T1[i].ToString());
                }
            }
            
            return text.ToArray();
        }

        public static string[] Tri()
        {
            T1.Sort(new HuileComparer());
            T1.Reverse();
            SauvegarderT1();
            return Liste();
        }

        public static double Valeur_total(string fournisseur)
        {
            double total = 0;
            for (int i = 0; i < T1.Count; i++)
            {
                Huile huile = (Huile)T1[i];
                if (huile.GetPetrolier().Equals(fournisseur))
                {
                    total += huile.GetPrix() * huile.GetStock();
                }
            }
            return total;
        }

        public static ArrayList Rupture_Stock()
        {
            ArrayList T2 = new ArrayList();
            for (int i = 0; i < T1.Count; i++)
            {
                Huile huile = (Huile)T1[i];
                if (huile.GetStock() == 0)
                {
                    T2.Add(huile);
                }
            }
            return T2;
        }

        public static ArrayList Destockage()
        {
            ArrayList T3 = new ArrayList();
            for (int i = 0; i < T1.Count; i++)
            {
                Huile huile = (Huile)T1[i];
                if (huile.GetStock()>0 && huile.GetStock() <= 5)
                {
                    double nouveauPrix = huile.GetPrix() - huile.GetPrix() * 40 / 100;
                    huile.SetPrix(nouveauPrix);
                    T3.Add(huile);
                }
            }
            SauvegarderT1();
            return T3;
        }

        public static ArrayList MaxVF()
        {
            ArrayList maxVF = new ArrayList();
            for (int i = 0; i < T1.Count; i++)
            {
                Huile huile = (Huile)T1[i];
                if (huile.GetVf() == 20)
                {
                    maxVF.Add(huile);
                }
            }
            return maxVF;
        }

        public static ArrayList MaxVC()
        {
            ArrayList maxVC = new ArrayList();
            for (int i = 0; i < T1.Count; i++)
            {
                Huile huile = (Huile)T1[i];
                if (huile.GetVc() == 50)
                {
                    maxVC.Add(huile);
                }
            }
            return maxVC;
        }

        public static ArrayList Viscosite_Max()
        {
            ArrayList viscositeMax = new ArrayList();
            for (int i = 0; i < T1.Count; i++)
            {
                Huile huile = (Huile)T1[i];
                if (huile.GetVf() == 20 || huile.GetVc() == 50)
                {
                    viscositeMax.Add(huile);
                }
            }
            return viscositeMax;
        }

        public static string Supprimer_Viscosite(int vf, int vc)
        {
            string message = "Aucun huile trouvé!";
            for (int i = 0; i < T1.Count; i++)
            {
                Huile huile = (Huile)T1[i];
                if (huile.GetVf().Equals(vf) && huile.GetVc().Equals(vc))
                {
                    T1.Remove(huile);
                    message = "Huiles supprimé avec succés";
                }
            }
            SauvegarderT1();

            return message;
        }

        public static void SauvegarderT1()
        {
            ArrayList list = new ArrayList();
            foreach (Huile huile in T1)
            {
                list.Add(huile.ToString());
            }
            File.WriteAllLines(@"Huiles.txt", list.Cast<string>());

        }

        public static object RestaurerT1()
        {
            string[] text = { };
            try {
                if (File.Exists(@"Huiles.txt"))
                {
                    text = File.ReadAllLines(@"Huiles.txt");

                    if (text.Length != 0)
                    {
                        foreach (string line in text)
                        {
                            string[] champs = line.Split('-');
                            Huile huile = new Huile(champs[0], Convert.ToInt32(champs[1]), Convert.ToInt32(champs[2]),
                                Convert.ToDouble(champs[3]), Convert.ToInt32(champs[4]), champs[5]);
                            Saisie(huile);
                        }

                    }
                }
            }
            catch (IOException e)
            {
                return "Erreur dans l'ouverture du fichier!";
            }catch(IndexOutOfRangeException e)
            {
                return "Le format du fichier est incompatible!";
            }

            return text;
        }

        public static object Menu(string boutton,params object[] champ)
        {
            switch (boutton)
            {
                case "Ajouter":
                        Saisie((Huile)champ[0]);
                    break;
                case "Lister":
                    return Liste();
                case "Trier":
                        Tri();
                    return Tri();
                case "Total":
                    return Valeur_total((string)champ[0]);
                case "Rupture":
                    return Rupture_Stock();
                case "Déstockage":
                    return Destockage();
                case "MaxVF":
                    return MaxVF();
                case "MaxVC":
                    return MaxVC();
                case "ViscositéMax":
                    return Viscosite_Max();
                case "Supprimer":
                    return Supprimer_Viscosite((int)champ[0], (int)champ[1]);
                
            }

            return null;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Huile());
        }
    }
}
