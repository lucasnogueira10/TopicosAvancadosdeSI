using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IAmbienteDB
    {
        bool Insert(Ambiente ambiente);
        bool Update(Ambiente ambiente, int id);
        bool Delete(int id);
        Ambiente SelectById(int id);
        List<Ambiente> GetAll();
    }
}
