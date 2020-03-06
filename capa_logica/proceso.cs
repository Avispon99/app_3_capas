using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public class proceso
    {
        public string resp;
        Conexion con = new Conexion();

        public void recept(string autenticacion ,string id, string nombre, string telefono, string cargo, string mail,
                               string perfil, string us, string clave, string estado)
        {
            
            capa_acceso_datos.conexion data = new capa_acceso_datos.conexion();

            if(autenticacion == "4819")
            {
                resp = " Autenticacion OK";

                con.insertar(id, nombre, telefono, cargo, mail, perfil, us, clave, estado));
            }
            else
            {
                resp = "Autenticacion Failed"; 
            }
            
        }

    }
}
