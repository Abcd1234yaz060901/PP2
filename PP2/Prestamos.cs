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
    public partial class Prestamos : Form
    {
        ProyectoFinalProgramacionII.Negocio.PrestamosEncabezado x = new ProyectoFinalProgramacionII.Negocio.PrestamosEncabezado();
        ProyectoFinalProgramacionII.Negocio.PrestamosDetalle y = new ProyectoFinalProgramacionII.Negocio.PrestamosDetalle();
        public Prestamos()
        {
            InitializeComponent();
        }

        private void CrearP_Click(object sender, EventArgs e)
        {
          

            MessageBox.Show(
               x.Crear(Convert.ToInt32(IdClienteText.Text), Convert.ToDouble(MontoPrestamoTextBox.Text), Convert.ToInt32(InteresAnualTexBox.Text), Convert.ToInt32(PeriodoPrestamosAñosTextBox.Text),Convert.ToDateTime(FechaInicioPrestamoTextBox.Value), Convert.ToDouble(PagosAdicionalesTextBox.Text),Convert.ToDouble(TotalPagosAnticipadosTextBox.Text)));
            prestamoDataGridView.DataSource = y.Actualizar(Convert.ToInt32(Id_PrestamoEncabezadoTextBox.Text));

            MessageBox.Show("Amotizacion Creada, para visualizarla favor busque el prestamo");

            Limpiar();
        }
        private void Limpiar()
        {
            Id_PrestamoEncabezadoTextBox.Clear();
            IdClienteText.Clear();
            MontoPrestamoTextBox.Clear();
            InteresAnualTexBox.Clear();
            PeriodoPrestamosAñosTextBox.Clear();
            NumeroPagosPorAñoTextBox.Clear();
            FechaInicioPrestamoTextBox.ResetText();

           
            CuotasPagarTextBox.Clear();
            NumeroProgramadoPagosTextBox.Clear();
            NumeroRealPagosTextBox.Clear();
          
            InteresTotalTextBox.Clear();


            prestamoDataGridView.DataSource = null;

        }

        private void ModificarP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
         x.Modificar(Convert.ToInt32(IdClienteText.Text), Convert.ToDouble(MontoPrestamoTextBox.Text), Convert.ToInt32(InteresAnualTexBox.Text), Convert.ToInt32(PeriodoPrestamosAñosTextBox.Text), Convert.ToDateTime(FechaInicioPrestamoTextBox.Value), Convert.ToDouble(PagosAdicionalesTextBox.Text), Convert.ToDouble(TotalPagosAnticipadosTextBox.Text), Convert.ToInt32(Id_PrestamoEncabezadoTextBox.Text)));

            Limpiar();
        }

        private void ActualizarP_Click(object sender, EventArgs e)
        {
            if (x.Actualizar() != null)
            {
                DataViewGridEncabezadoPrestamo.DataSource = x.Actualizar();

            }
            else
            {
                MessageBox.Show("no hay datos para mostrar");
            }
           
        }

   

         

        private void DataViewGridEncabezadoPrestamoCell(object sender, DataGridViewCellEventArgs e)
        {


            Id_PrestamoEncabezadoTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[0].Value.ToString();
            IdClienteText.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[1].Value.ToString();
            MontoPrestamoTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[2].Value.ToString();
            InteresAnualTexBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[3].Value.ToString();
            PeriodoPrestamosAñosTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[4].Value.ToString();

            NumeroPagosPorAñoTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[5].Value.ToString();
            FechaInicioPrestamoTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[6].Value.ToString();
            PagosAdicionalesTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[7].Value.ToString();
            CuotasPagarTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[8].Value.ToString();
            NumeroProgramadoPagosTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[9].Value.ToString();
            NumeroRealPagosTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[10].Value.ToString();
            TotalPagosAnticipadosTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[11].Value.ToString();
            InteresTotalTextBox.Text = DataViewGridEncabezadoPrestamo.Rows[e.RowIndex].Cells[12].Value.ToString();

          prestamoDataGridView.DataSource = y.Actualizar(Convert.ToInt32(Id_PrestamoEncabezadoTextBox.Text));

            tabPage1.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                x.Eliminar(Convert.ToInt32(Id_PrestamoEncabezadoTextBox.Text)));
            Limpiar();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var x = new Negocios.InputBox();
          
            string monto = "0.00";
            string IdDetalle = "0";
            if (x.InputBoxText("Aplicar Avance", "Digite del IdDetalle del Prestamo", ref IdDetalle) == DialogResult.OK)
            {
                if (x.InputBoxText("Aplicar Avance", "Digiete el Monto que desea Avanzar", ref monto) == DialogResult.OK)
                {
                    try
                    {
                        MessageBox.Show(
             y.AplicarAvence(Convert.ToDouble(monto), Convert.ToInt32(IdDetalle)));
                        prestamoDataGridView.DataSource = y.Actualizar(Convert.ToInt32(Id_PrestamoEncabezadoTextBox.Text));

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                  

                }
            }

           
        }
    }
}
