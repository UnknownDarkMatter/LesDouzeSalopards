using LesDouzeSalopards.Business;
using LesDouzeSalopards.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesDouzeSalopards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculePrime_Click(object sender, EventArgs e)
        {
            var listeCondamnés = RecupererListeCondamné();
            var moteurDeRègles = new MoteurDeRegles();
            var prime = moteurDeRègles.CalculePrimeFinale(listeCondamnés);

            txbPrime.Text = prime.Montant.ToString("0,##");
                

        }

        private List<Condamné> RecupererListeCondamné()
        {
            List<Condamné> listeDesCondamnés = new List<Condamné>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[1].Value == null) { continue; }

                Condamné newCondamné = new Condamné();
                newCondamné.Nom = row.Cells[0].Value?.ToString();
                switch (row.Cells[1].Value.ToString())
                {
                    case "Mort":
                        {
                            newCondamné.EtatCondamné = EtatCondamné.Mort;
                            break;
                        }
                    case "Vivant":
                        {
                            newCondamné.EtatCondamné = EtatCondamné.Vivant;
                            break;
                        }
                    default:
                        {
                            newCondamné.EtatCondamné = EtatCondamné.NonDefini;
                            break;
                        }
                }
                listeDesCondamnés.Add(newCondamné);
            }

            return listeDesCondamnés;
        }

       
    }
}
