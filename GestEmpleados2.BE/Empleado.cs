using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpleados2.BE
{
    public class Empleado
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Salario { get; set; }

        public void Agregar(string aDNI,
                            string aNombre,
                            string aEdad,
                            string aSalario)
        {
            DNI = Convert.ToInt32(aDNI);
            Nombre = aNombre;
            Edad = Convert.ToInt32(aEdad);
            Salario = Convert.ToInt32(aSalario);
        }

    }
}
