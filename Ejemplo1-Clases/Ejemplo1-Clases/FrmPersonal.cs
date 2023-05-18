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
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tex1.Text)) || !(string.IsNullOrEmpty(tex2.Text)))
            {
                Personal per = new Personal(tex1.Text, tex2.Text);
                Datos.Personanles.Add(per);
                FrmPersona person = new FrmPersona();
                person.ShowDialog();
                if (!(string.IsNullOrEmpty(person.tex1.Text)) || !(string.IsNullOrEmpty(person.tex2.Text)) ||
                    !(string.IsNullOrEmpty(person.tex3.Text)) || !(string.IsNullOrEmpty(person.tex4.Text)) ||
                    !(string.IsNullOrEmpty(person.text5.Text)))
                {
                    per.Id = person.tex1.Text;
                    per.Nombre = person.tex2.Text;
                    per.Direccion = person.tex3.Text;
                    per.Telf = person.tex4.Text;
                    per.Email = person.text5.Text;
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
    }
}
