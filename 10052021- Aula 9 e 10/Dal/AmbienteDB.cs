using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class AmbienteDB : IAmbienteDB
    {

        public List<Ambiente> GetAll()
        {
            List<Ambiente> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(Ambiente.GETALL));
            }
            return lst;
        }

        private List<Ambiente> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Ambiente>();

            while (returnData.Read())
            {
                var ambiente = new Ambiente()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Descricao = returnData["Descricao"].ToString(),
                };
                lst.Add(ambiente);
            }
            return lst;
        }

        public bool Insert(Ambiente ambiente)
        {
            bool status = false;
            string sql = string.Format(Ambiente.INSERT, ambiente.Descricao);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Ambiente SelectById(int id)
        {
            string sql = string.Format(Ambiente.GETBYID, id);
            Ambiente ambiente;

            using (var connection = new DB())
            {
                ambiente = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return ambiente;
        }

        public bool Update(Ambiente ambiente, int id)
        {
            bool status = false;
            string sql = string.Format(Ambiente.UPDATE, ambiente.Descricao, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Ambiente.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
