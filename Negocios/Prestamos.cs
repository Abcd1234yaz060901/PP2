using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace ProyectoFinalProgramacionII.Negocio

{
    public class PrestamosEncabezado
    {

        public int Id_PrestamoEncabezado { get; set; }
        public int Id_Cliente_FK { get; set; }
        public double MontoPrestamo { get; set; }
        public int InteresAnnual { get; set; }
        public int PeriodoPrestamoAnos { get; set; }
        public int NumeropagosAno { get; set; }
        public DateTime FechaInicioPrestamo { get; set; }
        public double PagosAdicionales { get; set; }
        public double CuotasPagar { get; set; }
        public int NumeroProgramadoPago { get; set; }
        public int NumeroRealPagos { get; set; }
        public double TotalPagosAnticipados { get; set; }
        public double InteresTotal { get; set; }

        Datos.PP2DBTableAdapters.PrestamoEncabezadoTableAdapter pe;
        PrestamosDetalle presdetalle;
        public PrestamosEncabezado()
        {
            try
            {
                pe = new Datos.PP2DBTableAdapters.PrestamoEncabezadoTableAdapter();
                presdetalle = new PrestamosDetalle();
            }
            catch (Exception ex)
            {
                //ex.Message;

            }
        }
        public string Crear(int Id_Cliente_FK, double MontoPrestamo, int InteresAnnual, int PeriodoPrestamoAnos, DateTime FechaInicioPrestamo, double PagosAdicionales, double TotalPagosAnticipados)
        {
            try
            {
                var cantidadcutoasAno = 12;
                var montoprestamo = MontoPrestamo;
              
                var anosprestamo = PeriodoPrestamoAnos;
                var interesAnual = ((montoprestamo * InteresAnnual) / 100);
                var montoprestamo2 = MontoPrestamo + interesAnual;
                var NumeroCuotas = (anosprestamo * cantidadcutoasAno);
                var NumeroCuotas2 = (anosprestamo * cantidadcutoasAno);
                var capital = 0.00;
                var interes = 0.00;
                var interesesacumulados = 0.00;
                var saldoinicial = montoprestamo2;

                if (ValidarPrestamo(Id_Cliente_FK) == true)
                {
                    pe.InsertQuery(Id_Cliente_FK, MontoPrestamo, InteresAnnual, PeriodoPrestamoAnos, Convert.ToString(FechaInicioPrestamo), PagosAdicionales, TotalPagosAnticipados);

                    // Crear la Tabla de Amortizacion
                    for (int i = 1; i <= NumeroCuotas2; i++)
                    {
                        saldoinicial = saldoinicial - capital - interes;
                        capital = (montoprestamo / NumeroCuotas);
                        interes = (interesAnual / NumeroCuotas);
                        interesesacumulados = interesesacumulados + interes;
                        montoprestamo = montoprestamo - capital;
                        interesAnual = ((montoprestamo * InteresAnnual) / 100);
                        NumeroCuotas = NumeroCuotas - 1;
                      

                        presdetalle.Crear(FechaInicioPrestamo, saldoinicial, capital, interes, interesesacumulados);


                    }


                    return "Prestamo Creado con Exito";
                }
                else
                {
                    return "Este Cliente tiene un prestamo activos";
                }
              
            }
            catch (Exception ex)
            {
               
                return ex.Message;
            }

        }
        public string Eliminar(int Id_PrestamoEncabezado)
        {

            try
            {
                presdetalle.Eliminar(Id_PrestamoEncabezado);

                pe.DeleteQuery(Id_PrestamoEncabezado);
             

                return "Prestamo Eliminado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }
        public string Modificar(int Id_Cliente_FK,double MontoPrestamo, int InteresAnnual, int PeriodoPrestamoAnos, DateTime FechaInicioPrestamo, double PagosAdicionales, double TotalPagosAnticipados,  int Id_PrestamoEncabezado)
        {

            try
            {
                var cantidadcutoasAno = 12;
                var montoprestamo = MontoPrestamo;

                var anosprestamo = PeriodoPrestamoAnos;
                var interesAnual = ((montoprestamo * InteresAnnual) / 100);
                var montoprestamo2 = MontoPrestamo + interesAnual;
                var NumeroCuotas = (anosprestamo * cantidadcutoasAno);
                var NumeroCuotas2 = (anosprestamo * cantidadcutoasAno);
                var capital = 0.00;
                var interes = 0.00;
                var interesesacumulados = 0.00;
                var saldoinicial = montoprestamo2;

                pe.UpdateQuery(Id_Cliente_FK, MontoPrestamo, InteresAnnual, PeriodoPrestamoAnos, Convert.ToString(FechaInicioPrestamo), PagosAdicionales, TotalPagosAnticipados,Id_PrestamoEncabezado);
                
                presdetalle.Eliminar(Id_PrestamoEncabezado);
                // Crear la Tabla de Amortizacion
                for (int i = 1; i <= NumeroCuotas2; i++)
                {
                    saldoinicial = saldoinicial - capital - interes;
                    capital = (montoprestamo / NumeroCuotas);
                    interes = (interesAnual / NumeroCuotas);
                    interesesacumulados = interesesacumulados + interes;
                    montoprestamo = montoprestamo - capital;
                    interesAnual = ((montoprestamo * InteresAnnual) / 100);
                    NumeroCuotas = NumeroCuotas - 1;


                    presdetalle.Crear(FechaInicioPrestamo, saldoinicial, capital, interes, interesesacumulados);


                }
                return "prestamo Modificado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public DataTable Actualizar()
        {

            try
            {
                return pe.GetData();
            }
            catch (Exception)
            {

                return null;
            }
          
        }
        public DataTable ActualizarByClientes(int Id_PrestamoEncabezado)
        {

            try
            {
                return pe.GetDataByCliente(Id_PrestamoEncabezado);
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public bool ValidarPrestamo(int idcliente)
        {
            try
            {
                if (Convert.ToInt32(pe.CantPrestamo(idcliente)) > 0)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            }
            catch (Exception ex)
            {

                return false;
            }

            

        }

    }

    public class PrestamosDetalle
    {
        public int Id_PrestamoDetalle { get; set; }
        public int Id_PrestamoEncabezado_FK { get; set; }
        public DateTime FechaPago { get; set; }
        public double SaldoInicial { get; set; }
        public double Cuotas { get; set; }
        public double Avances { get; set; }
        public double PagoTotal { get; set; }
        public double Capital { get; set; }
        public double Interes { get; set; }
        public double BalanceFinal { get; set; }
        public double InteresAcumulado { get; set; }

        Datos.PP2DBTableAdapters.PrestamoDetalleTableAdapter pd;
        Datos.PP2DBTableAdapters.PrestamoEncabezadoTableAdapter pres;
        public PrestamosDetalle()
        {
            try
            {
                pd = new Datos.PP2DBTableAdapters.PrestamoDetalleTableAdapter();
                pres = new Datos.PP2DBTableAdapters.PrestamoEncabezadoTableAdapter();
            }
            catch (Exception ex)
            {
                //ex.Message;

            }
        }
        public string Crear( DateTime FechaPago,double SaldoInicial, double Capital, double Interes, double InteresAcumulado)
        {

            try
            {
                pd.InsertQuery(Convert.ToInt32(pres.UltimoIDPrestamo()),Convert.ToString(FechaPago),SaldoInicial,0 ,Capital,Interes ,InteresAcumulado );

                return "Detalle  Creado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string Eliminar(int Id_PrestamoDetalle)
        {
            try
            {
                pd.DeleteQuery(Id_PrestamoDetalle);

                return "Detalle Eliminado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }
        public string AplicarAvence(double Monto,int Id)
        {
            try
            {
                pd.AplicarAvance(Monto,Id);

                return "Avance Aplicado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public DataTable Actualizar(int id)
        {
            try
            {
                return pd.GetDataByPrestamo(id);
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }

    }
