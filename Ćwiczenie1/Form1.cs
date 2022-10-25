using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ćwiczenie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const float pasek = 4.75f;
            int ocenaPolski = int.Parse(polski.Text);
            int ocenaMatma = int.Parse(matematyka.Text);
            int ocenaFizyka = int.Parse(fizyka.Text);

            bool czyOcenySaPoprawne = ocenaPolski <= 6 && ocenaMatma <=6 && ocenaFizyka <=6;
            bool czyOcenyUjemne = ocenaPolski >= 1 && ocenaMatma >= 1 && ocenaFizyka >= 1; 

            if (czyOcenySaPoprawne && czyOcenyUjemne)
            {
                float srednia = (float)(ocenaPolski + ocenaMatma + ocenaFizyka) / 3;

                if (srednia >= pasek)
                {
                    MessageBox.Show(srednia + " Gratulacje, otrzymujesz czerwony pasek");
                }
                else
                {
                    MessageBox.Show(srednia + " Niestety nie udało się otrzymać czerwonego paska");
                }
            }
            else
            {
                MessageBox.Show("Wprowadznone oceny są niepoprawne");
            }
            
        }
    }
}
