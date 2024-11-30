using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
                string textoTelegrama;
                int numPalabras = 0;
                double coste;

                //Leo el telegrama.
                textoTelegrama = txtTelegrama.Text;
                // telegrama urgente?

                //Separo las palabras del texto.
                string[] palabras = textoTelegrama.Split(' ');
                //Obtengo el número de palabras que forma el telegrama
                numPalabras = palabras.Length;

            //Si el telegrama NO está vacío 
            if (!(textoTelegrama.Equals("")))
            {
                //Si el telegrama es ordinario
                if (rdbOrdinario.Checked == true)
                {
                    if (numPalabras <= 10 && numPalabras > 0)
                    {
                        coste = 3;
                    }
                    else
                    {
                        coste = 3 + 0.5 * (numPalabras - 10);
                    }
                }
                else
                //Si el telegrama es urgente 
                {
                    if (numPalabras <= 10)
                    {
                        coste = 6;
                    }
                    else
                    {
                        coste = 6 + 0.75 * (numPalabras - 10);
                    }
                }
            }
            else
            {
                coste = 0;
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void rdbOrdinario_CheckedChanged(object sender, EventArgs e)
        {
            //Si marco ordinario debo desmarcar urgente
            if (rdbOrdinario.Checked)
            {
                rdbUrgente.Checked = false;
            }
            
        }

        private void rdbUrgente_CheckedChanged(object sender, EventArgs e)
        {
            //Si marco urgente debo desmarcar ordinario
            if (rdbUrgente.Checked)
            {
                rdbOrdinario.Checked = false;

            }
        }
    }
}
