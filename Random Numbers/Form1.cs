using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers
{
    public partial class form : Form
    {
        //Random Generator
        Random rnd = new Random();

        


        public form()
        {
            InitializeComponent();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            //Random Double
            int numMin = Convert.ToInt32(txtMin.Text);
            int numMax = Convert.ToInt32(txtMax.Text);
            double Number  = rnd.Next(numMin, numMax);
            double Decimal = rnd.NextDouble();
            Number = Number + Decimal;
            lblOutput.Text = ($"{Number}");
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            //Random Intager
            int numMin = Convert.ToInt32(txtMin.Text);
            int numMax = Convert.ToInt32(txtMax.Text);
            double Number = rnd.Next(numMin, numMax);
            Number = Number + 1;
            lblOutput.Text = ($"{Number}");
        }
    }
}
