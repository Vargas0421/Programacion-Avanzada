using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraSoucion.Calculadora
{
    public partial class Form1 : Form
    {
        double numeroUno = 0;
        double numeroDos = 0;
        double resultado = 0;
        string operador = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(VentanaResultadosTXT.Text == "0"){
                VentanaResultadosTXT.Text = "";
            }
            else{
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "1";
            }
        }
        private void BTNNumber2_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0"){
                VentanaResultadosTXT.Text = "";
            }
            else{
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "2";
            }

        }
        private void BTNNUmber3_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "6";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "9";
            }
        }

       


        private void BTNIgual_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    
                    Sumar();
                    break;
                case "-":
                    
                    Restar();
                    break;
                case "*":
                        Multiplicar();
                        break;
                case "/":
                        Dividir();
                    break;
                case "%":
                    Dividir();
                    break;
                case "^":
                    Potencia();
                    break;
                default:
                    
                        break;
                    
       
            }
        }

        private void Sumar()
        {
            numeroDos = double.Parse(VentanaResultadosTXT.Text);
            resultado = numeroUno + numeroDos;
            VentanaResultadosTXT.Text = resultado.ToString();
        }
        private void BTNSuma_Click(object sender, EventArgs e)
        {
            numeroUno = double.Parse(VentanaResultadosTXT.Text);
            VentanaResultadosTXT.Text = string.Empty;//esto lo que ahce es vaciar el string 
            operador = "+";

        }
        private void Restar()
        {
            numeroDos = double.Parse(VentanaResultadosTXT.Text);
            resultado = numeroUno - numeroDos;
            VentanaResultadosTXT.Text = resultado.ToString();
        }
        private void BTNResta_Click(object sender, EventArgs e)
        {
            numeroUno = double.Parse(VentanaResultadosTXT.Text);
            VentanaResultadosTXT.Text = string.Empty;//esto lo que ahce es vaciar el string 
            operador = "-";
        }
        private void Multiplicar()
        {
            numeroDos = double.Parse(VentanaResultadosTXT.Text);
            resultado = numeroUno * numeroDos;
            VentanaResultadosTXT.Text = resultado.ToString();
        }
        private void BTNMultiplicacion_Click(object sender, EventArgs e)
        {
            numeroUno = double.Parse(VentanaResultadosTXT.Text);
            VentanaResultadosTXT.Text = string.Empty;//esto lo que ahce es vaciar el string 
            operador = "*";
        }
        private void Dividir()
        {
            numeroDos = double.Parse(VentanaResultadosTXT.Text);
            if (numeroDos == 0)
            {
                MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VentanaResultadosTXT.Text = string.Empty;//esto lo que ahce es vaciar el string 
                return;
            }
            resultado = numeroUno / numeroDos;
            VentanaResultadosTXT.Text = resultado.ToString();
        }
        private void BTNDivision_Click(object sender, EventArgs e)
        {
            numeroUno = double.Parse(VentanaResultadosTXT.Text);
            VentanaResultadosTXT.Text = string.Empty;//esto lo que ahce es vaciar el string 
            operador = "/";
        }

        private void Residuo()
        {
            numeroDos = double.Parse(VentanaResultadosTXT.Text);
            resultado = numeroUno % numeroDos;
            VentanaResultadosTXT.Text = resultado.ToString();   
        }
        private void BTNResiduo_Click(object sender, EventArgs e)
        {
            numeroUno = double.Parse(VentanaResultadosTXT.Text);
            VentanaResultadosTXT.Text = string.Empty;//esto lo que ahce es vaciar el string 
            operador = "%";
        }

        private void Potencia()
        {
            numeroDos = double.Parse(VentanaResultadosTXT.Text);
            resultado = Math.Pow(numeroUno, numeroDos);
            VentanaResultadosTXT.Text = resultado.ToString();
        }
        

        private void BTNPotencia_Click(object sender, EventArgs e)
        {
            numeroUno = double.Parse(VentanaResultadosTXT.Text);
            VentanaResultadosTXT.Text = string.Empty;//esto lo que ahce es vaciar el string 
            operador = "^";
        }
    

        private void BTNNumero4_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "4";
            }
        }

        private void BTNNumero7_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "7";
            }
        }

        private void BTNNumero8_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "8";
            }
        }

        private void BTNNumero0_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + "0";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text == "0")
            {
                VentanaResultadosTXT.Text = "";
            }
            else
            {
                VentanaResultadosTXT.Text = string.Empty;
            }
        }

        private void BTNPuntoDecimal_Click(object sender, EventArgs e)
        {
                if (VentanaResultadosTXT.Text != "")
                {
                    VentanaResultadosTXT.Text = VentanaResultadosTXT.Text + ",";
                }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (VentanaResultadosTXT.Text != string.Empty)
            {
                int largoDelTexto = VentanaResultadosTXT.Text.Length;
                VentanaResultadosTXT.Text = VentanaResultadosTXT.Text.Substring(0, largoDelTexto - 1);
            }
        }
    }
}
