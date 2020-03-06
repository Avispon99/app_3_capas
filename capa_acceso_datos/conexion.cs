using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace capa_acceso_datos
{
    public class conexion
    {
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        DataTable dt;
        MySqlDataAdapter d;

        public Conexion()
        {
            try
            {
                cn = new MySqlConnection("Server = localhost; port = 3306; user id = root; password =; database = gestion_usuarios;");
                cn.Open();
                MessageBox.Show("OK");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.ToString());
            }

        }

        public string insertar(string id, string nombre, string telefono, string cargo, string mail,
                               string perfil, string us, string clave, string estado)
        {
            string salida = "se inserto!";
            try
            {
                cmd = new MySqlCommand("Insert into registro_usuarios(identificacion,nombre_apellido," +
                                       "telefono,cargo,e_mail,perfil,usuario,contraseña,estado) " +
                                       "values('" + id + "','" + nombre + "','" + telefono + "','" + cargo + "','" + mail + "','" + perfil + "','" + us + "','" + clave + "','" + estado + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se inserto" + ex;

            }
            return salida;
        }

        public void CargarBase(DataGridView dv)
        {
            try
            {
                d = new MySqlDataAdapter("Select * from registro_usuarios", cn);
                dt = new DataTable();
                d.Fill(dt);
                dv.DataSource = dt;
            }
            catch (Exception exe)
            {
                MessageBox.Show("Error al cargar la Base de Datos en el DatagridView \n" + exe);
            }
        }
    }
}
