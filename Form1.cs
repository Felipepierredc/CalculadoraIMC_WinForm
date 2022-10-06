using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTentativa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void botaoCalcular_Click(object sender, EventArgs e) 
        {
           
                double peso, altura, imc;

                peso = double.Parse(inputPeso.Text);
                altura = double.Parse(inputAltura.Text);

            

                imc = peso / (altura* altura);

                string imcresultado = Convert.ToString(imc);

                outputResultado.Text = "Seu IMC é: " + Math.Round(imc, 2);
                }
      
        }
      }
}