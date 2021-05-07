using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ferramenta
    {
        #region Propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Preco { get; set; }

        public const string INSERT = "INSERT INTO TB_FERRAMENTAA (descricao, tipo, marca, preco) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public const string GETALL = "SELECT id, descricao, tipo, marca, preco FROM TB_FERRAMENTAA";
        public const string UPDATE = "UPDATE TB_FERRAMENTAA SET descricao = '{0}', tipo = '{1}', marca = '{2}', preco = '{3}' WHERE id = {4}";
        public const string DELETE = "DELETE FROM TB_FERRAMENTAA WHERE id = {0}";
        public const string GETBYID = "SELECT id, descricao, tipo, marca, preco FROM TB_FERRAMENTAA WHERE id = {0}";


        public override string ToString()
        {
            return "ID: " + this.Id + "\nDescrição: " + this.Descricao + "\nTipo: " + this.Tipo 
                + "\nMarca: " + this.Marca + "\nPreço: " + this.Preco + "\n\n";
        }

        #endregion

    }
}
