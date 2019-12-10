using ProyectoFinalProgramacionII.Negocio;
using System;
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
    public partial class Cliente : Form
    {

        ProyectoFinalProgramacionII.Negocio.Cliente x = new ProyectoFinalProgramacionII.Negocio.Cliente();
        ProyectoFinalProgramacionII.Negocio.PrestamosEncabezado y = new ProyectoFinalProgramacionII.Negocio.PrestamosEncabezado();

        public Cliente()
        {
            InitializeComponent();

        }

        private void CrearC_Click(object sender, EventArgs e)
        {

                MessageBox.Show(
                x.Crear(nombreTextBox.Text, apellidoTextBox.Text, cedulaTextBox.Text, fechaNacimientoDateTimePicker.Value.Date, Convert.ToInt32(edadTextBox.Text), direccionTextBox.Text, telefonoTextBox.Text, celularTextBox.Text));
                Limpiar();
            
        }

        private void Limpiar()
        {
            id_clienteTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            cedulaTextBox.Clear();
            edadTextBox.Clear();
            direccionTextBox.Clear();
            telefonoTextBox.Clear();
            celularTextBox.Clear();


        }

        private void ModificarC_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
          x.Modificar(nombreTextBox.Text, apellidoTextBox.Text, cedulaTextBox.Text, fechaNacimientoDateTimePicker.Value.Date, Convert.ToInt32(edadTextBox.Text), direccionTextBox.Text, telefonoTextBox.Text, celularTextBox.Text, Convert.ToInt32(id_clienteTextBox.Text)));

        }

        private void ActualizarC_Click(object sender, EventArgs e)
        {
             if (x.ActualizarCliente() != null)
            {
                ClienteDataGriew.DataSource = x.ActualizarCliente();

            }
            else
            {
                MessageBox.Show("no hay datos para mostrar");
            }

        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarC_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                 x.Eliminar(Convert.ToInt32(id_clienteTextBox.Text)));
        }

        private void ClienteDataGriew_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_clienteTextBox.Text = ClienteDataGriew.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombreTextBox.Text = ClienteDataGriew.Rows[e.RowIndex].Cells[1].Value.ToString();
            apellidoTextBox.Text = ClienteDataGriew.Rows[e.RowIndex].Cells[2].Value.ToString();
            cedulaTextBox.Text = ClienteDataGriew.Rows[e.RowIndex].Cells[3].Value.ToString();
            fechaNacimientoDateTimePicker.Value = Convert.ToDateTime(ClienteDataGriew.Rows[e.RowIndex].Cells[4].Value);
            edadTextBox.Text = ClienteDataGriew.Rows[e.RowIndex].Cells[5].Value.ToString();

            telefonoTextBox.Text = ClienteDataGriew.Rows[e.RowIndex].Cells[6].Value.ToString();
            celularTextBox.Text = ClienteDataGriew.Rows[e.RowIndex].Cells[7].Value.ToString();
            direccionTextBox.Text = ClienteDataGriew.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            try
            {
               
                    if (y.Actualizar() != null)
                    {
                        prestamosporclientedataviewgrid.DataSource = y.ActualizarByClientes(Convert.ToInt32(textBox1.Text));

                    }
                    else
                    {
                        MessageBox.Show("no hay datos para mostrar");
                    }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese el id del cliente");

            }

        }
    }
}



