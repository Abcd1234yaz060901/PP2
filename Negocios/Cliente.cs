using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace ProyectoFinalProgramacionII.Negocio
{
   public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        String  Cedula { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono  { get; set; }
        public string Celular { get; set; }
        Datos.PP2DBTableAdapters.ClienteTableAdapter cli;


        public Cliente()
        {
            try
            {
                cli = new Datos.PP2DBTableAdapters.ClienteTableAdapter();
            }
            catch (Exception ex)
            {
                //ex.Message;

            }


        }
        public String Crear (string Nombre, String Apellido, String Cedula, DateTime FechaNacimiento ,int Edad, String Direccion, String Telefono, String Celular)
        {

            try
            {
                cli.InsertQuery(Nombre, Apellido, Cedula, FechaNacimiento, Edad, Direccion, Telefono, Celular);

                return "Cliente Creado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string Modificar (string Nombre,String Apellido, String Cedula, DateTime FechaNacimiento, int Edad,String Direccion,String Telefono, String Celular,int id_cliente)
        {

            try
            {
                cli.UpdateQuery(Nombre, Apellido, Cedula, FechaNacimiento, Edad, Direccion, Telefono, Celular, id_cliente);

                return "Cliente Modificado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }
        public DataTable ActualizarCliente()
        {
            try
            {
              return cli.GetData();
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        public String Eliminar(int Id_cliente)
        {
            try
            {
                cli.DeleteQuery(Id_cliente);

                return "Cliente Eliminado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        
        }

    }
}
