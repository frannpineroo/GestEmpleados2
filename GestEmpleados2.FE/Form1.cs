using GestEmpleados2.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestEmpleados2.FE
{
    public partial class Form1 : Form
    {
        Empleados ListaEmpleados { get; set; } = new Empleados();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = ListaEmpleados.ListaDT;
        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Agregar(txtNombre.Text,
                        txtEdad.Text,
                        txtSalario.Text);
            ListaEmpleados.InsertEmpleado(emp);
            txtDNI.Text = emp.DNI.ToString();
        }

      
    }
}
