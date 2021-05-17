using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IOrcamentoDB
    {
        bool Insert(Orcamento orcamento);
        bool Update(Orcamento orcamento, int id);
        bool Delete(int id);
        Orcamento SelectById(int id);
        List<Orcamento> GetAll();
    }
}
