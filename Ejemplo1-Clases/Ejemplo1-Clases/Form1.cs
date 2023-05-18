using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro cen = new FrmCentro();
            cen.ShowDialog();       
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesor profe = new FrmProfesor();
            profe.ShowDialog();
            
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEstudiante estidy = new FrmEstudiante();
            estidy.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonal person = new FrmPersonal();
            person.ShowDialog();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros ltc = new ListaCentros();
            ltc.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesores ltpr = new ListaProfesores();
            ltpr.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEstudiantes lte = new ListaEstudiantes();
            lte.ShowDialog();
        }

        private void listaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPersonal ltp = new ListaPersonal();
            ltp.ShowDialog();
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
