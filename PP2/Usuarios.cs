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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        ProyectoFinalProgramacionII.Negocio.Usuarios x = new ProyectoFinalProgramacionII.Negocio.Usuarios();
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           x.Crear(nombreTextBox.Text,correoTextBox.Text,claveTextBox.Text, estadoCheckBox.Checked));
            Limpiar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           x.Modificar(nombreTextBox.Text, correoTextBox.Text, claveTextBox.Text, estadoCheckBox.Checked, Convert.ToInt32(id_UUsuarioTextBox.Text)));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                x.Eliminar(Convert.ToInt32(id_UUsuarioTextBox.Text)));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (x.Actualizar() != null)
            {
                usuarioDataGridView.DataSource = x.Actualizar();

            }
            else
            {
                MessageBox.Show("no hay datos para mostrar");
            }
        }
     
        private void LimbiarBoton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            id_UUsuarioTextBox.Clear();
            nombreTextBox.Clear();
            correoTextBox.Clear();
            claveTextBox.Clear();
            estadoCheckBox.Checked = false;

           
        }

        private void UsuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_UUsuarioTextBox.Text = usuarioDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombreTextBox.Text= usuarioDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            correoTextBox.Text= usuarioDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            claveTextBox.Text= usuarioDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            estadoCheckBox.Checked = Convert.ToBoolean(usuarioDataGridView.Rows[e.RowIndex].Cells[4].Value);
        }
    }

}
