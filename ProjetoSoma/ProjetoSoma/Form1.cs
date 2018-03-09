using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjetoSoma.Modelo;

namespace ProjetoSoma
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Num1 = txbPrimeiroNumero.Text;
            controle.Num2 = txbSegundoNumero.Text;
            controle.Op = "+";
            controle.Calcular();
            lblResultado.Text = controle.Resposta;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
