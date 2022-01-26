using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiedraPapelTijera
{
    
    public partial class Form_Principal : Form
    {
        
        
        private int valorBoti;
        public Form_Principal(string nombreQueViene)
        {
            InitializeComponent();
            this.label2.Text = nombreQueViene;
            this.lbl_eleccionBoti.Visible = false;
            this.lbl_resultado.Visible = false;
            this.label4.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_piedra_Click(object sender, EventArgs e)
        {
            Jugar(0);
        }

        private void btn_papel_Click(object sender, EventArgs e)
        {
           Jugar(1);
        }

        private void btn_tijera_Click(object sender, EventArgs e)
        {
           Jugar(2);
        }

        private void Jugar(int valor)
        {
            Random r = new Random();
            valorBoti = r.Next(1, 4);
            this.lbl_eleccionBoti.Visible = true;
            this.lbl_resultado.Visible = true;
            this.label4.Visible = true;
            switch (valorBoti)
            {
                case 1:
                    this.lbl_eleccionBoti.Text = "Piedra";
                    if(valor == 0)
                    {
                        this.lbl_resultado.Text = "Empate";
                    }
                    else if(valor == 1)
                    {
                        this.lbl_resultado.Text = "Ganaste";
                    }
                    else
                    {
                        this.lbl_resultado.Text = "Perdiste";
                    }
                    break;
                case 2:
                    this.lbl_eleccionBoti.Text = "Papel";
                    if (valor == 0)
                    {
                        this.lbl_resultado.Text = "Perdiste";
                    }
                    else if (valor == 1)
                    {
                        this.lbl_resultado.Text = "Empate";
                    }
                    else
                    {
                        this.lbl_resultado.Text = "Ganaste";
                    }
                    break;
                case 3:
                    this.lbl_eleccionBoti.Text = "Tijera";
                    if (valor == 0)
                    {
                        this.lbl_resultado.Text = "Ganaste";
                    }
                    else if (valor == 1)
                    {
                        this.lbl_resultado.Text = "Perdiste";
                    }
                    else
                    {
                        this.lbl_resultado.Text = "Empate";
                    }
                    break;
            }
           
            
        }

     
    }
}
 