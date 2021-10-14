using AllMath.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 Cl = new Class1();
            String X = TxtFrecuencia.Text;
            int Frecuencia = Int32.Parse(X);

            String Y = TxtTotalFrecuencia.Text;
            int TotalFrecuencia = Int32.Parse(Y);

            int Result = Cl.Angulo(Frecuencia, TotalFrecuencia);
            TxtTotalAngulo.Text = Result.ToString();
        }


    }
}
