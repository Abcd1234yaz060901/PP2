using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace ProyectoFinalProgramacionII.Negocio
{
 
   public class Usuarios
    {
        public int Id_UUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }

        Datos.PP2DBTableAdapters.UsuarioTableAdapter usr;

        public Usuarios()
        {
            try
            {
                usr = new Datos.PP2DBTableAdapters.UsuarioTableAdapter();
            }
            catch (Exception ex)
            {
                //ex.Message;
               
            }
           

        }

        public bool ValidarLogin(string nombre, string clave)
        {
            try
            {
                if (Convert.ToInt32(usr.ValidarUsuarios(nombre, clave)) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                
            }

           
        }
        public string Crear(string Nombre, string Correo, string Clave, bool Estado)
        {
            try
            {
                usr.InsertQuery(Nombre, Correo, Clave, Estado);

                return "Usuario Creado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }
        public string Modificar(string Nombre, string Correo, string Clave, bool Estado, int Id_UUsuario)
        {
            try
            {
                usr.UpdateQuery(Nombre, Correo, Clave, Estado, Id_UUsuario);

                return "Usuario Modificado con Exito";
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
                return usr.GetData();
            }
            catch (Exception)
            {

                return null;
            }
           
           
        }
        public string Eliminar(int Id_UUsuario)
        {
            try
            {
                usr.DeleteQuery(Id_UUsuario);

                return "Usuario Eliminado con Exito";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
           


        }
    }
}
