using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    public class CategorieId
    {
        Conexion cn = new Conexion();

        public DataTable CargarCombo()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SP_CARGARCOMBOBOX",cn.LeerCadena());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
