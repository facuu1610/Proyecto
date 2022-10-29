using PoliTech.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliTech.Datos
{
    class Socios
    {
        public static bool guardar(Socios e)
        {
            try
            {
                conexion con = new conexion();
                string sql = "INSERT INTO tb_socios VALUES ";
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
