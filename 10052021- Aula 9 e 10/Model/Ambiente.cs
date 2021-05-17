using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ambiente
    {
        public const string INSERT = "INSERT INTO TB_AMBIENTE (descricao) VALUES ('{0}')";
        public const string GETALL = "SELECT id, descricao FROM TB_AMBIENTE";
        public const string UPDATE = "UPDATE TB_AMBIENTE SET descricao = '{0}' WHERE id = {1}";
        public const string DELETE = "DELETE FROM TB_AMBIENTE WHERE id = {0}";
        public const string GETBYID = "SELECT id, descricao FROM TB_AMBIENTE WHERE id = {0}";

        #region Propriedades  
        public int Id { get; set; }
        public string Descricao { get; set; }
        #endregion
    }
}
