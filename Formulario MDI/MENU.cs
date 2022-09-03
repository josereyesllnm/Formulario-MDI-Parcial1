using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACERCADE f2 = new ACERCADE();
            f2.ShowDialog();
        }

        private void cuadroDeDialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuadroDeDialogos f4 = new CuadroDeDialogos();
            f4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.ShowDialog();
        }

        private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfertasDelMes f7 = new OfertasDelMes();
            f7.ShowDialog();
        }

        private void menu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GamaAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             form9 f9 = new form9();
            f9.ShowDialog();
        }

        private void opcion3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACCESORIOS f8 = new ACCESORIOS();
            f8.ShowDialog();
        }

        private void GamaMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortatilesGamaMedia f10 = new PortatilesGamaMedia();
            f10.ShowDialog();
        }

        private void GamaBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortatilesGamaBaja f11 = new PortatilesGamaBaja();
            f11.ShowDialog();
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gamaltaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscritorioGamaAlta f12 = new EscritorioGamaAlta();
            f12.ShowDialog();

        }

        private void gamamediaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscritorioGamaMedia f13 = new EscritorioGamaMedia();
            f13.ShowDialog();

        }

        private void gamabajaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscritorioGamaBaja f14 = new EscritorioGamaBaja();
            f14.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AYUDA f3 = new AYUDA();
            f3.ShowDialog();
        }
    }

}
