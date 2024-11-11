using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaterní_testy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tlacitkoVyhodnot_Click(object sender, EventArgs e)
        {
            bool iALT;
            bool iAST;
            bool ibilirubin;

            double ALT;
            double AST;
            double bilirubin;

            try
            {
                ALT = Convert.ToDouble(poleALT.Text);
                AST = Convert.ToDouble(poleAST.Text);
                bilirubin = Convert.ToDouble(poleBilirubin.Text);

                iALT = ALT >= 0.16 && ALT <= 0.57;
                iAST = AST >= 0.15 && AST <= 0.72;
                ibilirubin = bilirubin >= 0 && bilirubin <= 25.7;
            }
            catch
            {
                return;
            }

            if (iALT && iAST && ibilirubin)
            { 
                MessageBox.Show("Všechny testy máte v pořádku.");
            }
            else
            {
                MessageBox.Show("Testy nejsou v pořádku.");
            }
            if (!iALT)
            {
                MessageBox.Show("ALT mimo normu.");
            }
            if (!iAST)
            {
                MessageBox.Show("AST mimo normu.");
            }
            if (!ibilirubin)
            {
                MessageBox.Show("Bilirubin mimo normu.");
            }
        }
    }
}
