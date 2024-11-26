using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para_practicar
{
    public class Datos
    {
        
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public double Tamaño { get; set; }



            public override string ToString()
            {
                return "Nombre: "+Nombre+ " Edad: "+Edad+ "Tamaño:" +Tamaño;
            }
        }
    }

