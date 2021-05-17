using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class SquadDB : ISquadDB
    {
        public List<Squad> GetAll()
        {
            string sql = Squad.GETALL;
            List<Squad> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Squad> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Squad>();

            while (returnData.Read())
            {
                var item = new Squad()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Nome = returnData["nome"].ToString(),
                    QtdPessoas = int.Parse(returnData["qtdpessoas"].ToString()),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Squad squad)
        {
            bool status = false;
            string sql = string.Format(Squad.INSERT, squad.Nome, squad.QtdPessoas);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Squad SelectById(int id)
        {
            string sql = string.Format(Squad.GETBYID, id);
            Squad squad;

            using (var connection = new DB())
            {
                squad = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return squad;
        }

        public bool Update(Squad squad, int id)
        {
            bool status = false;
            string sql = string.Format(Squad.UPDATE, squad.Nome, squad.QtdPessoas, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Squad.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
