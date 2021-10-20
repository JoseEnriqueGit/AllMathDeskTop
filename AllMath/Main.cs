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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        private void MathBtn_Click(object sender, EventArgs e)
        {
            if (SubPanelMath.Visible)
            {
                SubPanelMath.Visible = false;
            }
            else
            {
                SubPanelStatistics.Visible = false;
                SubPanelPhysical.Visible = false;
                SubPanelMath.Visible = true;
            }
        }

        private void PhysicalBtn_Click_1(object sender, EventArgs e)
        {
            if (SubPanelPhysical.Visible)
            {
                SubPanelPhysical.Visible = false;
            }
            else
            {
                SubPanelMath.Visible = false;
                SubPanelStatistics.Visible = false;
                SubPanelPhysical.Visible = true;
            }
        }


        private void StatisticsBtn_Click(object sender, EventArgs e)
        {
            if (SubPanelStatistics.Visible)
            {
                SubPanelStatistics.Visible = false;
            }
            else
            {
                SubPanelMath.Visible = false;
                SubPanelPhysical.Visible = false;
                SubPanelStatistics.Visible = true;
            }
        }

        private void GraficaBtn_Click(object sender, EventArgs e)
        {
            loadform(new GraficosForm());
        }
    }
}
