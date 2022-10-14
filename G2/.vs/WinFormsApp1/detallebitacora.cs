using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioClinico
{
    class detallebitacora
    {

       public void agregar(string modulo)
        {

            string[] a;
            conexion con = new conexion();
           
            string sql2 = "SELECT MAX(id_bitacora) from bitacora";
            a = con.buscar(sql2, 1);

            string sql = "insert into detallebitacora (bitacora, modulo, accion,  hora) values ('"+ a[0] +"','" + modulo + "', 'insercion ','" + DateTime.Now.ToString("hh:mm:ss") + "' )";
            con.IDU2(sql);
        }
        
        public void eliminar(string modulo)
        {

            string[] a;
            conexion con = new conexion();
           
            string sql2 = "SELECT MAX(id_bitacora) from bitacora";
            a = con.buscar(sql2, 1);

            string sql = "insert into detallebitacora (bitacora, modulo, accion,  hora) values ('"+ a[0] +"','" + modulo + "', 'eliminacion ','" + DateTime.Now.ToString("hh:mm:ss") + "' )";
            con.IDU2(sql);
        }
        
        public void actualizar(string modulo)
        {

            string[] a;
            conexion con = new conexion();
           
            string sql2 = "SELECT MAX(id_bitacora) from bitacora";
            a = con.buscar(sql2, 1);

            string sql = "insert into detallebitacora (bitacora, modulo, accion,  hora) values ('"+ a[0] +"','" + modulo + "', 'actualizacion ','" + DateTime.Now.ToString("hh:mm:ss") + "' )";
            con.IDU2(sql);
        }
        
        public void busqueda(string modulo)
        {

            string[] a;
            conexion con = new conexion();
           
            string sql2 = "SELECT MAX(id_bitacora) from bitacora";
            a = con.buscar(sql2, 1);

            string sql = "insert into detallebitacora (bitacora, modulo, accion,  hora) values ('"+ a[0] +"','" + modulo + "', 'busqueda ','" + DateTime.Now.ToString("hh:mm:ss") + "' )";
            con.IDU2(sql);
        }

       
    }

}
