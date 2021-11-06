using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class ConnectionDados 
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();
        public SqlDataReader dr;
        SqlDataAdapter da;
        public DataSet ds;

        public void Conectar()
        {
            cn.ConnectionString = "SERVER=VINICIUSMR\\SQLEXPRESS;Database=Mechanical Technology Automotive;UID=sa;PWD=8520;";
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }

        public void Execultar(string Sql)
        {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = Sql;

            cd.ExecuteNonQuery();
            Desconectar();
        }

        public DataSet GetDataGrid(string Sql)
        {
            try
            {
                Conectar();
                da = new SqlDataAdapter(Sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                Desconectar();
            }
            catch (Exception x)
            {

            }
            
            return ds;
        }

        public void Consulta(string Sql)
        {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = Sql;
            dr = cd.ExecuteReader();
        }
    }
}
