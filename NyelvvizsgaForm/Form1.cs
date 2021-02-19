using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyelvvizsgaForm
{
    public partial class btnSikertelen : Form
    {
        bool sikeresBeolvasas = false;
        bool sikertelenBeolvasas = false;

        public btnSikertelen()
        {
            InitializeComponent();
        }

        private void btnSiker_Click(object sender, EventArgs e)
        {
            if (ofdSikeres.ShowDialog() == DialogResult.OK)
            {
                // Ellenőrizni, hogy "sikeres.csv" van-e beolvasva
                sikeresBeolvasas = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofdSikertelen.ShowDialog() == DialogResult.OK)
            {
                // Ellenőrizni, hogy "sikertelen.csv" van-e beolvasva
                sikertelenBeolvasas = true;
            }
        }

        private void btnElso_Click(object sender, EventArgs e)
        {
            if (MindenBeolvasva())
            {
                MessageBox.Show("Lehet megoldani");
            }
            else
            {
                MessageBox.Show("Először be kell olvasni!");
            }
        }

        private bool MindenBeolvasva()
        {
            return sikeresBeolvasas && sikertelenBeolvasas;
        }
    }
}
