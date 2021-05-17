using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Squad
    {
        public const string INSERT = "INSERT INTO TB_SQUAD (nome, qtdpessoas) VALUES ('{0}', '{1}')";
        public const string GETALL = "SELECT id, nome, qtdpessoas FROM TB_SQUAD";
        public const string UPDATE = "UPDATE TB_SQUAD SET nome = '{0}', qtdpessoas = {1} WHERE id = {2}";
        public const string DELETE = "DELETE FROM TB_SQUAD WHERE id = {0}";
        public const string GETBYID = "SELECT id, nome, qtdpessoas FROM TB_SQUAD WHERE id = {0}";

        #region Propriedades  
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdPessoas { get; set; }
        #endregion
    }
}
