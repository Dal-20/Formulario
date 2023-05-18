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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tex1.Text)) || !(string.IsNullOrEmpty(tex2.Text)))
            {
                Profesor profe = new Profesor(tex1.Text, double.Parse(tex2.Text));
                Datos.Profesores.Add(profe);
                FrmPersona person = new FrmPersona();
                person.ShowDialog();
                if (!(string.IsNullOrEmpty(person.tex1.Text)) || !(string.IsNullOrEmpty(person.tex2.Text)) ||
                    !(string.IsNullOrEmpty(person.tex3.Text)) || !(string.IsNullOrEmpty(person.tex4.Text)) ||
                    !(string.IsNullOrEmpty(person.text5.Text)))
                {
                    profe.Id = person.tex1.Text;
                    profe.Nombre = person.tex2.Text;
                    profe.Direccion = person.tex3.Text;
                    profe.Telf = person.tex4.Text;
                    profe.Email = person.text5.Text;
                    DialogResult resp = DialogResult.Yes;
                    while (resp == DialogResult.Yes)
                    {
                        FrmCentro cen = new FrmCentro();
                        cen.ShowDialog();
                        if (!(string.IsNullOrEmpty(cen.tex1.Text)) || !(string.IsNullOrEmpty(cen.tex2.Text)) ||
                            !(string.IsNullOrEmpty(cen.tex3.Text)) || !(string.IsNullOrEmpty(cen.tex4.Text)))
                        {
                            Centro centro = new Centro();
                            centro.Nombre = cen.tex1.Text;
                            centro.Dir = cen.tex2.Text;
                            centro.Telf = cen.tex3.Text;
                            centro.Email = cen.tex4.Text;
                            profe.Centros.Add(centro);
                            this.Close();
                            resp = MessageBox.Show("Hay mas centros?", "confirmar", MessageBoxButtons.YesNo);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Favor llenar los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
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
    }
}
