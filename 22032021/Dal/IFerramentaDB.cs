using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IFerramentaDB
    {
        bool Insert(Ferramenta ferramenta);
        bool Update(Ferramenta ferramenta);
        bool Delete(int id);
        Ferramenta SelectById(int id);
        List<Ferramenta> GetAll();
    }
}
