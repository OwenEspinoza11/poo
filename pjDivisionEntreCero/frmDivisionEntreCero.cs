using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjDivisionEntreCero
{
    public partial class frmDivisionEntreCero : Form
    {
        public frmDivisionEntreCero()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturando datos
                int numerador = int.Parse(txtNumerador.Text);
                int denominador = int.Parse(txtDenominador.Text);

                // Realizando cálculo
                double resultado = numerador / denominador;

                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Debe escribir dos enteros", 
                    "Formato de número inválido",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch(DivideByZeroException divideByZeroExceptionParameter)
            {
                MessageBox.Show(divideByZeroExceptionParameter.Message,
                    "Intento de división por cero", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
