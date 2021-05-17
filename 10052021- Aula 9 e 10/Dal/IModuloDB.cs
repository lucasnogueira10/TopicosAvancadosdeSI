using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IModuloDB
    {
        bool Insert(Modulo modulo);
        bool Update(Modulo modulo, int id);
        bool Delete(int id);
        Modulo SelectById(int id);
        List<Modulo> GetAll();
    }
}
