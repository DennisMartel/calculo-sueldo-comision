using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tulen_Dennis
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Empleado empleado = new Empleado();
        Limpiar lmp = new Limpiar();

        public void Capturar()
        {
            empleado.cargo = CaputarTextoRadioButton();
            empleado.sueldo = Convert.ToDouble(txtSueldoBase.Text);
            empleado.ventas = Convert.ToInt32(txtVentasRealizadas.Text);
        }

        public string CaputarTextoRadioButton()
        {
            string valor = "";

            if (radJefe.Checked) 
                valor = radJefe.Text;
            else if (radSupervisor.Checked) 
                valor = radSupervisor.Text;
            else if (radVendedor.Checked) 
                valor = radVendedor.Text;

            return valor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lmp.Borrar(this, grpDatosEmpleado);
            txtNombre.Focus();
            lblResComision.Text = "La comision es de: $";
            lblResNuevoSueldo.Text = "Su nuevo sueldo es de: $";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Capturar();
                lblResComision.Text = "La comision es de: $" + empleado.CalcularComision().ToString();
                lblResNuevoSueldo.Text = "Su nuevo sueldo es de: $" + empleado.CalcularNuevoSueldo().ToString();
            } catch
            {
                MessageBox.Show("Error, Dato no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
