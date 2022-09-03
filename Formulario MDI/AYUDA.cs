using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class AYUDA : Form
    {
        public AYUDA()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de realizar esta valoracion de el sistema?                   ", " Confirmacion de valoracion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por tus aportes                                                          "
                +
                   "           Peticion de valoracion enviada !!!", " Computers Guevara.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
