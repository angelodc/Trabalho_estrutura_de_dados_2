using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estrutura_grafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //fazer um forech de objetos
            this.chart1.Series["Tique"].Points.AddXY("100", 33);

            this.chart1.Series["Comparações"].Points.AddXY("50", 300);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Tique"].Points.AddXY("100", 44);
            this.chart1.Series["Comparações"].Points.AddXY("100", 300);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
