using ProyectoFinalProgramacionII.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private System.ComponentModel.IContainer components = null;

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Usuarios"] == null)
                BotonUsuarios.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Cliente"] == null)
                BotonClientes.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Prestamo"] == null)
                BotonPrestamos.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["PagosPrestamos"] == null)
                BotonPrestamos.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void BotonUsuarios_Click(object sender, EventArgs e)
        {
            ;
        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void BotonPrestamos_Click(object sender, EventArgs e)
        {
        }

        private void BotonPagoPrestamos_Click(object sender, EventArgs e)
        {
           
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void BotonUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Usuarios>();
            BotonUsuarios.BackColor = Color.FromArgb(12, 61, 92);
        }

        //private void BotonPrestamos_Click_1(object sender, EventArgs e)
        //{
        //    AbrirFormulario<Prestamos>();
        //    BotonUsuarios.BackColor = Color.FromArgb(12, 61, 92);
        //}

        //private void BotonPagoPrestamos_Click_1(object sender, EventArgs e)
        //{
        //    AbrirFormulario<PagosPrestamos>();
        //    BotonPagoPrestamos.BackColor = Color.FromArgb(12, 61, 92);
        //}

        private void BotonClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Cliente>();
            BotonUsuarios.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void BotonPrestamos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Prestamos>();
            BotonUsuarios.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
