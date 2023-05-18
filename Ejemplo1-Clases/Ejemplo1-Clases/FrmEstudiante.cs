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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tex1.Text)) ||! (string.IsNullOrEmpty(tex2.Text)))
            {
                
                Alumno est = new Alumno(tex1.Text, tex2.Text);
                Datos.Alumnos.Add(est);
                FrmPersona person = new FrmPersona();
                person.ShowDialog();
                if (!(string.IsNullOrEmpty(person.tex1.Text)) || !(string.IsNullOrEmpty(person.tex2.Text)) ||
                    !(string.IsNullOrEmpty(person.tex3.Text)) || !(string.IsNullOrEmpty(person.tex4.Text)) ||
                    !(string.IsNullOrEmpty(person.text5.Text)))
                { 
                    est.Id = person.tex1.Text;
                    est.Nombre = person.tex2.Text;
                    est.Direccion = person.tex3.Text;
                    est.Telf = person.tex4.Text;
                    est.Email = person.text5.Text;
                    FrmCentro c = new FrmCentro();
                    c.ShowDialog();
                    if (!(string.IsNullOrEmpty(c.tex1.Text)) || !(string.IsNullOrEmpty(c.tex2.Text))||
                        !(string.IsNullOrEmpty(c.tex3.Text)) || !(string.IsNullOrEmpty(c.tex4.Text)))
                    {
                        est.Centro = new Centro(c.tex1.Text, c.tex2.Text, c.tex3.Text, c.tex4.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Favor llenar los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Favor llenar los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor llenar los campos vacios","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
