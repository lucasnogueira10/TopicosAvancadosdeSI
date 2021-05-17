using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ISquadDB
    {
        bool Insert(Squad squad);
        bool Update(Squad squad, int id);
        bool Delete(int id);
        Squad SelectById(int id);
        List<Squad> GetAll();
    }
}
