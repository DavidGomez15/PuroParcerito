using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfazzz
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        
        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void BtnN1_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "1";
        }

        private void BtnN0_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "2";
        }

        private void BtnN3_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "3";
        }

        private void BtnN4_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "4";
        }
    }
}
