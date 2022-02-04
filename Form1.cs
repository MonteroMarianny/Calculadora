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
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5
    }
    public partial class Calculadora : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion Operador = Operacion.NoDefinida; 
        public Calculadora()
        {
            InitializeComponent();
        }
        private void Numero(string numero)
        {
            if (textCalculadora.Text == "0" && textCalculadora.Text != null)
            {
                textCalculadora.Text = numero;
            }
            else
            {
                textCalculadora.Text += numero;     
            }
        }
        private double EjecutarOperacion()
        {
            double Resultado = 0;
            switch (Operador)
            {
              
                case Operacion.Suma:
                    Resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    Resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        Resultado = 0;
                    }
                    else
                    {
                        Resultado = valor1 / valor2;
                    }                  
                    break;
                case Operacion.Multiplicacion:
                    Resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    Resultado = valor1 % valor2;
                    break;
            }
            return Resultado; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Numero("2");
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            
            
        }

        private void but1_Click(object sender, EventArgs e)
        {
            Numero("1");
            
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "0")
            {
                return;
            }
            else
            {
                textCalculadora.Text += "0";
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            Numero("3");
        }

        private void but4_Click(object sender, EventArgs e)
        {
            Numero("4");
        }

        private void but5_Click(object sender, EventArgs e)
        {
            Numero("5");
        }

        private void but6_Click(object sender, EventArgs e)
        {
            Numero("6");
        }

        private void but7_Click(object sender, EventArgs e)
        {
            Numero("7");
        }

        private void but8_Click(object sender, EventArgs e)
        {
            Numero("8");
        }

        private void but9_Click(object sender, EventArgs e)
        {
            Numero("9");
        }
        private void ObtenerValor(String Operador)
        {
            valor1 = Convert.ToDouble(textCalculadora.Text);
            LabResultado.Text = textCalculadora.Text + Operador;
            textCalculadora.Text = "0";
        }
        private void butSumar_Click(object sender, EventArgs e)
        {
            Operador = Operacion.Suma;
            ObtenerValor("+");
           

        }

        private void butIgual_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(textCalculadora.Text);
                LabResultado.Text += valor2 + "=";
                double Resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                textCalculadora.Text = Convert.ToString(Resultado);
            }
        }

        private void butRestar_Click(object sender, EventArgs e)
        {
            Operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void butMultiplicar_Click(object sender, EventArgs e)
        {
            Operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void butDividir_Click(object sender, EventArgs e)
        {
            Operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void butModulo_Click(object sender, EventArgs e)
        {
            Operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void butBorrarTodo_Click(object sender, EventArgs e)
        {
            textCalculadora.Text = "0";
            LabResultado.Text = "";
        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text.Length > 1)
            {
                string textResultado = textCalculadora.Text;
                textResultado = textResultado.Substring(0, textResultado.Length - 1);
                if (textResultado.Length == 1 && textResultado.Contains("-"))
                {
                    textCalculadora.Text = "0";
                }
                else
                {
                    textCalculadora.Text = textResultado;
                }
                
            }
        }

        private void butPunto_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text.Contains("."))
            {
                return;
            }
            textCalculadora.Text = ".";
        }
    }
}
