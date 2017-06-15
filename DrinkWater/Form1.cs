using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkWater
{
    public partial class Form1 : Form
    {
        int hora;
        int minuto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (btnAtivar.Text == "Ativar")
            {
                btnAtivar.Text = "Desativar";

                hora = Convert.ToInt16(txtHora.Text);
                minuto = Convert.ToInt16(txtMinuto.Text);
                lblHora.Text = Convert.ToString(hora);
                timer1.Start();
            }
            else timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minuto > 0)
            {
                minuto--;
                lblMinuto.Text = Convert.ToString(minuto);


            }
            else
            {
                if (hora > 0)
                {
                    hora--;


                    minuto = 60;
                }
                lblHora.Text = Convert.ToString(hora);
            }
            if (minuto == 0 && hora == 0)
            {
                timer1.Stop();
                MessageBox.Show("Vá se hidratar, hora de beber água!");
                hora = Convert.ToInt16(txtHora.Text);
                minuto = Convert.ToInt16(txtMinuto.Text);
                lblHora.Text = Convert.ToString(hora);
                timer1.Start();
            }

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblMinuto_Click(object sender, EventArgs e)
        {

        }

        private void txtMinuto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
