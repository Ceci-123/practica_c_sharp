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
    public partial class Form_ingresoNombre : Form
    {
        
        public Form_ingresoNombre()
        {
            InitializeComponent();
        }

        private void button1_ok_Click(object sender, EventArgs e)
        {
            Form_Principal formulario = new Form_Principal(this.textBox1_nombre.Text);
            formulario.Show();
            //Thread.Sleep(5000);
            //this.Close();
        }

        private void button2_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
