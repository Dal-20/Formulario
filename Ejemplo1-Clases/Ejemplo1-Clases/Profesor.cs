using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    
    class Profesor:Persona
    {
    
        string iNSS;
        double salario;
       
        public List<Centro> Centros = new List<Centro>();
        
        public Profesor()
        { }
        public Profesor(string iNSS, double salario)
            
        {
            this.iNSS = iNSS;
            this.salario = salario;
            
        }
        
        public string INSS
        {
            get
            {
                return iNSS;
            }

            set
            {
                iNSS = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }
    }
}
