using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class miCalculadora : Form
    {

        bool lValidar = true;
        string cOperacion = "+";
        string cOperacion1 = " ";
        decimal nCaputura;
        decimal nTotal;
        public miCalculadora()
        {
            InitializeComponent();
        }
        private void miCalculadora_Load(object sender, EventArgs e)
        {
            lblCaptura.Text = "";
            lblDisplay.Text = "";
        }

        public void InsertarNumero(char cCaracter)
        {
            if (lValidar)
            {
                lblCaptura.Text = " ";
                lblCaptura.Text = Convert.ToString(cCaracter);
                lValidar = false;
            }
            else
            {
                lblCaptura.Text = lblCaptura.Text + cCaracter;
            }
        }
        private void btnCero_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0")
            {
                return;
            }
            else
            {
                InsertarNumero('0');
            }
                
        }
        private void btnUno_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-1";
            }
            else
            {
                InsertarNumero('1');
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-2";
            }
            else
            {
                InsertarNumero('2');
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-3";
            }
            else
            {
                InsertarNumero('3');
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-4";
            }
            else
            {
                InsertarNumero('4');
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-5";
            }
            else
            {
                InsertarNumero('5');
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-6";
            }
            else
            {
                InsertarNumero('6');
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-7";
            }
            else
            {
                InsertarNumero('7');
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-8";
            }
            else
            {
                InsertarNumero('8');
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text == "0" && cOperacion == "-")
            {
                lblCaptura.Text = "-9";
            }
            else
            {
                InsertarNumero('9');
            }
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            
            if (lblCaptura.Text.Contains("."))
            {
                return;
            }
            else
            {
                InsertarNumero('.');
            }
        }


        private void btnMas_Click(object sender, EventArgs e)
        {
            cOperacion = "+";
            nCaputura = Convert.ToDecimal(lblCaptura.Text);
            lblDisplay.Text = nCaputura.ToString() + ' ' + cOperacion;
            lblCaptura.Text = "";
            lValidar = true;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            cOperacion = "-";
            nCaputura = Convert.ToDecimal(lblCaptura.Text);
            lblDisplay.Text = nCaputura.ToString() + ' ' + cOperacion;
            lblCaptura.Text = "";
            lValidar = true;
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            cOperacion = "*";
            nCaputura = Convert.ToDecimal(lblCaptura.Text);
            lblDisplay.Text = nCaputura.ToString() + ' ' + cOperacion;
            lblCaptura.Text = "";
            lValidar = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cOperacion = "/";
            nCaputura = Convert.ToDecimal(lblCaptura.Text);
            lblDisplay.Text = nCaputura.ToString() + ' ' + cOperacion;
            lblCaptura.Text = "";
            lValidar = true;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblCaptura.Text = "0";
            lblDisplay.Text = "";
            nCaputura = 0;
            cOperacion = "";
            lValidar = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lblCaptura.Text.Length == 1)
            {
                lblCaptura.Text = "0";
                lValidar = true;
            }
            else
            {
                lblDisplay.Text = "";
                lblCaptura.Text = lblCaptura.Text.Substring(0, lblCaptura.Text.Length - 1);
                
            }
        }
      
        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (cOperacion)
            {
                case "+":
                    nTotal = nCaputura + Convert.ToDecimal(lblCaptura.Text);
                    lblDisplay.Text = lblDisplay.Text + " " + lblCaptura.Text + " = ";
                    lblCaptura.Text = nTotal.ToString();
                        break;
                case "-":
                    nTotal = nCaputura - Convert.ToDecimal(lblCaptura.Text);
                    lblDisplay.Text = lblDisplay.Text + " " + lblCaptura.Text + " = ";
                    lblCaptura.Text = nTotal.ToString();
                    break;
                case "*":
                    nTotal = nCaputura * Convert.ToDecimal(lblCaptura.Text);
                    lblDisplay.Text = lblDisplay.Text + " " + lblCaptura.Text + " = ";
                    lblCaptura.Text = nTotal.ToString();
                    break;
                case "/":
                    nTotal = nCaputura / Convert.ToDecimal(lblCaptura.Text);
                    lblDisplay.Text = lblDisplay.Text + " " + lblCaptura.Text + " = ";
                    lblCaptura.Text = nTotal.ToString();
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
