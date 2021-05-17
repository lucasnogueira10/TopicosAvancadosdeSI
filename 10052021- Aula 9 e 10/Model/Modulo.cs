using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Modulo
    {
        public const string GETALL = "SELECT id, ambiente, squad FROM TB_MODULO";
        public const string INSERT = "INSERT INTO TB_MODULO (ambiente, squad) VALUES ('{0}', '{1}')";
        public const string GETBYID = "SELECT id, ambiente, squad FROM TB_MODULO WHERE id = {0}";
        public const string UPDATE = "UPDATE TB_MODULO SET ambiente = '{0}', squad = '{1}' WHERE id = {2}";
        public const string DELETE = "DELETE FROM TB_MODULO WHERE id = {0}";

        #region Propriedades  
        public int Id { get; set; }
        public string Ambiente { get; set; }
        public string Squad { get; set; }
        #endregion
    }
}
