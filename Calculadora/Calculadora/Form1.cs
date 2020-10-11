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
    public partial class frmCalculadora : Form
    {
        string operador1, operador2, operacion;
        Operacion ejecutar = new Operacion();

        //funcion para desabilitar botones 
        public void Deshabilitar(bool valor)
        {
            btnCero.Enabled = valor;
            btnUno.Enabled = valor;
            btnDos.Enabled = valor;
            btnTres.Enabled = valor;
            btnCuatro.Enabled = valor;
            btnCinco.Enabled = valor;
            btnSeis.Enabled = valor;
            btnSiete.Enabled = valor;
            btnOcho.Enabled = valor;
            btnNueve.Enabled = valor;
            btnSuma.Enabled = valor;
            btnResta.Enabled = valor;
            btnMultiplicacion.Enabled = valor;
            btnDivision.Enabled = valor;
            btnModulo.Enabled = valor;
            btnFactorial.Enabled = valor;
            btnIgual.Enabled = valor;
            
        }
        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "7";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "7";
                lblInput.Text += "7";
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "8";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "8";
                lblInput.Text += "8";
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "9";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "9";
                lblInput.Text += "9";
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "4";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "4";
                lblInput.Text += "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "5";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "5";
                lblInput.Text += "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "6";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "6";
                lblInput.Text += "6";
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "1";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "1";
                lblInput.Text += "1";
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "2";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "2";
                lblInput.Text += "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "3";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "3";
                lblInput.Text += "3";
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                operador1 += "0";
                lblInput.Text = operador1;
            }
            else
            {
                operador2 += "0";
                lblInput.Text += "0";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (operador1 == "")
            {
                MessageBox.Show("Ingrese el primer valor.");

            }
            else if (operacion != "")
            {
                MessageBox.Show("Ya ingreso un signo de operación.");
            }
            else
            {
                lblInput.Text += " - ";
                operacion = "resta";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (operador1 == "")
            {
                MessageBox.Show("Ingrese el primer valor.");

            }
            else if (operacion != "")
            {
                MessageBox.Show("Ya ingreso un signo de operación.");
            }
            else
            {
                lblInput.Text += " / ";
                operacion = "division";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (operador1 == "")
            {
                MessageBox.Show("Ingrese el primer valor.");

            }
            else if (operacion != "")
            {
                MessageBox.Show("Ya ingreso un signo de operación.");
            }
            else
            {
                lblInput.Text += " * ";
                operacion = "multiplicacion";
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (operador1 == "")
            {
                MessageBox.Show("Ingrese el primer valor.");

            }
            else if (operacion != "")
            {
                MessageBox.Show("Ya ingreso un signo de operación.");
            }
            else
            {
                lblInput.Text += " + ";
                operacion = "suma";
            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (operador1 == "")
            {
                MessageBox.Show("Ingrese el primer valor.");

            }
            else if (operacion != "")
            {
                MessageBox.Show("Ya ingreso un signo de operación.");
            }
            else
            {
                lblInput.Text += " % ";
                operacion = "modulo";
            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int num;
            if (operador1 == "")
            {
                MessageBox.Show("Ingrese el primer valor.");

            }
            else if (operacion != "")
            {
                MessageBox.Show("Ya ingreso un signo de operación.");
            }
            else
            {
                if (operador1.Contains("."))
                {
                    Deshabilitar(false);
                    MessageBox.Show("Por favor ingrese valores enteros.");
                }
                else
                {
                    Deshabilitar(false);
                    num = int.Parse(operador1);
                    lblResultado.Text = ejecutar.Factorial(num).ToString();
                }
                
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double res=0;
            if (operador1=="" || operador2 =="")
            {
                MessageBox.Show("Ingrese valores.");


            }
            else if (operacion == "suma")
            {
                res = ejecutar.Suma(double.Parse(operador1), double.Parse(operador2));
            }
            else if (operacion == "resta")
            {
                res = ejecutar.Resta(double.Parse(operador1), double.Parse(operador2));
            }
            else if (operacion =="multiplicacion")
            {
                res = ejecutar.Multiplicacion(double.Parse(operador1), double.Parse(operador2));
            }
            else if (operacion == "division")
            {
                res = Math.Round(ejecutar.Division(double.Parse(operador1), double.Parse(operador2)),2);
            }
            else if (operacion == "modulo")
            {
                res = ejecutar.Modulo(double.Parse(operador1), double.Parse(operador2));
            }
            Deshabilitar(false);
            lblResultado.Text = res.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblInput.Text = "";
            operador1 = "";
            operador2 = "";
            operacion = "";
            Deshabilitar(true);
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (operador1 == "" && operador2 == "")
            {
                MessageBox.Show("El valor ingresado es incorrecto");
            }
            else if (operador2 == "" && operador1 != "" && operacion!="")
            {
                MessageBox.Show("El valor ingresado es incorrecto");
            }
            else if (operador1.Contains(".") && operador2 =="")
            {
                MessageBox.Show("Valor no permitido");
            }
            else if (operador2.Contains(".") && operador1 != "" && operacion != "")
            {
                MessageBox.Show("Valor no permitido");
            }
            else if (operacion == "")
            {
                operador1 += ".";
                lblInput.Text = operador1;
            }
            else if (operacion != "")
            {
                operador2 += ".";
                lblInput.Text += ".";
            }
        }

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            operador1 = "";
            operador2 = "";
            operacion = "";
        }
    }
}
