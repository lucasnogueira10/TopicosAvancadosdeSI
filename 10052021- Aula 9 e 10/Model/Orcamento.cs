using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orcamento
    {
        public const string INSERT = "INSERT INTO TB_ORCAMENTO (dtinicio, dtfim, qtdias, descricao, titulo, id_modulo) VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}')";
        public const string GETALL = "SELECT id, dtinicio, dtfim, qtdias, descricao, titulo, id_modulo FROM TB_ORCAMENTO";
        public const string UPDATE = "UPDATE TB_ORCAMENTO SET dtinicio = '{0}', dtfim = '{1}', qtdias = {2}, descricao = '{3}', titulo = '{4}', id_modulo = '{5}' WHERE id = {6}";
        public const string DELETE = "DELETE FROM TB_ORCAMENTO WHERE id = {0}";
        public const string GETBYID = "SELECT id, dtinicio, dtfim, qtdias, descricao, titulo, id_modulo FROM TB_ORCAMENTO WHERE id = {0}";

        #region Propriedades  
        public int Id { get; set; }
        public string DtInicio { get; set; }
        public string DtFim { get; set; }
        public int QtdDias { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public string Modulo { get; set; }
        #endregion
    }
}
