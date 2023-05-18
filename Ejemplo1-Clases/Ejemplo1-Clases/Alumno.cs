using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
   
    class Alumno:Persona
    {
       
        string exp;
        string tiulacion;
       
        public Centro Centro;
      
        public Alumno()
        { }
        public Alumno(string exp, string tiulacion)
        {
            this.exp = exp;
            this.tiulacion = tiulacion;
        }

        public string Exp
        {
            get
            {
                return exp;
            }

            set
            {
                exp = value;
            }
        }

        public string Tiulacion
        {
            get
            {
                return tiulacion;
            }

            set
            {
                tiulacion = value;
            }
        }
    }
}
