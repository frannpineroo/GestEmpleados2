using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpleados2.BE
{
    public class Empleados
    {
        public DataTable ListaDT { get; set; } = new DataTable();

        public Empleados()
        {
            ListaDT.TableName = "ListaPersonas";
            ListaDT.Columns.Add("Nombre");
            ListaDT.Columns.Add("Salario");
            ListaDT.Columns.Add();
            ListaDT.Columns.Add();
            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Empleados.xml"))
            {
                ListaDT.ReadXml("Empleados.xml");
            }
        }

        public void InsertEmpleado(Empleado aEmpleado)
        {
            ListaDT.Rows.Add(); 
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["DNI"] = aEmpleado.DNI;
            ListaDT.Rows[NuevoRenglon]["Nombre"] = aEmpleado.Nombre;
            ListaDT.Rows[NuevoRenglon]["Edad"] = aEmpleado.Edad;
            ListaDT.Rows[NuevoRenglon]["Salario"] = aEmpleado.Salario;

            ListaDT.WriteXml("Empleados.xml");
        }

        
    }
            
}
