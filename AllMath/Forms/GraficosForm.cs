using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;


namespace AllMath
{
    public partial class GraficosForm : Form
    {
        GraficasPastel GraficaCls = new GraficasPastel();
        public GraficosForm()
        {
            InitializeComponent();
        }

        private void AnguloBtn_Click(object sender, EventArgs e)
        {
            String X = TxtFrecuencia.Text;
            int Frecuencia = Int32.Parse(X);

            String Y = TxtSumaFrecuencia.Text;
            int SumaFrecuencia = Int32.Parse(Y);

            int Result = GraficaCls.Angulo(Frecuencia, SumaFrecuencia);
            TxtResultAngulo.Text = Result.ToString();
        }
    }
}
