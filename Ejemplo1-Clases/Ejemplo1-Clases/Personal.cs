using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
   
    class Personal:Persona
    {
     
        string unidad;
        string categoria;
       
         public Personal()
        { }
        public Personal(string unidad, string categoria)
        {
            this.unidad = unidad;
            this.categoria = categoria;
        }

        public string Unidad
        {
            get
            {
                return unidad;
            }

            set
            {
                unidad = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }
    }
}
