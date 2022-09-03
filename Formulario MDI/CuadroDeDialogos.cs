using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class CuadroDeDialogos : Form
    {
        public CuadroDeDialogos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Boton de aceptar", " Mensaje Aceptar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Botones Aceptar y Cancelar", " Mensaje OK Cancel", MessageBoxButtons.OKCancel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Botones Sí, No y Cancelar", " Mensaje Yes No Cancel", MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Boton Aceptar", " Mensaje Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
