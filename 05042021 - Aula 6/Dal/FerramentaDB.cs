using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class FerramentaDB : IFerramentaDB
    {

        public List<Ferramenta> GetAll()
        {
            string sql = Ferramenta.GETALL;
            List<Ferramenta> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Ferramenta> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Ferramenta>();

            while (returnData.Read())
            {
                var item = new Ferramenta()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Descricao = returnData["descricao"].ToString(),
                    Tipo = returnData["tipo"].ToString(),
                    Marca = returnData["marca"].ToString(),
                    Preco = returnData["preco"].ToString()
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Ferramenta ferramenta)
        {
            bool status = false;
            string sql = string.Format(Ferramenta.INSERT, ferramenta.Descricao, ferramenta.Tipo, ferramenta.Marca, ferramenta.Preco);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Ferramenta SelectById(int id)
        {
            string sql = string.Format(Ferramenta.GETBYID, id);
            Ferramenta employee;

            using (var connection = new DB())
            {
                employee = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return employee;
        }

        public bool Update(Ferramenta ferramenta, int id)
        {
            bool status = false;
            string sql = string.Format(Ferramenta.UPDATE, ferramenta.Descricao, ferramenta.Tipo, ferramenta.Marca, ferramenta.Preco, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Ferramenta.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
