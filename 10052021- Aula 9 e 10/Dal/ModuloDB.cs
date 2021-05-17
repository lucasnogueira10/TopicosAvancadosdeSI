using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ModuloDB : IModuloDB
    {
        public List<Modulo> GetAll()
        {
            string sql = Modulo.GETALL;
            List<Modulo> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Modulo> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Modulo>();

            while (returnData.Read())
            {
                var modulo = new Modulo()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Ambiente = returnData["ambiente"].ToString(),
                    Squad = returnData["squad"].ToString(),
                };
                lst.Add(modulo);
            }
            return lst;
        }

        public bool Insert(Modulo modulo)
        {
            bool status = false;
            string sql = string.Format(Modulo.INSERT, modulo.Ambiente, modulo.Squad);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Modulo SelectById(int id)
        {
            string sql = string.Format(Modulo.GETBYID, id);
            Modulo modulo;

            using (var connection = new DB())
            {
                modulo = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return modulo;
        }

        public bool Update(Modulo modulo, int id)
        {
            bool status = false;
            string sql = string.Format(Modulo.UPDATE, modulo.Ambiente, modulo.Squad, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Modulo.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
