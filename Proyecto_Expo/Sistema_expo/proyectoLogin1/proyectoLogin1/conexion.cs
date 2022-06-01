using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace proyectoLogin1
{
    class conexion
    {
        string usuario, servidor, bd, cadena;
        MySqlConnection con;

        public conexion()
        {
            usuario = "root";
            servidor = "127.0.0.1";
            bd = "Mueble_SV";
            cadena = "server=" + servidor + ";uid=" + usuario + "; Database=" + bd;

            con = new MySqlConnection(cadena);
        }

        public MySqlConnection conectar()
        {
            return con;
        }

    }
}
