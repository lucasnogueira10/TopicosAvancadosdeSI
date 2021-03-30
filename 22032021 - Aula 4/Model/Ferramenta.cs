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

        public override string ToString()
        {
            return "ID: " + this.Id + "\nDescrição: " + this.Descricao + "\nTipo: " + this.Tipo 
                + "\nMarca: " + this.Marca + "\nPreço: " + this.Preco + "\n\n";
        }

        #endregion

    }
}
