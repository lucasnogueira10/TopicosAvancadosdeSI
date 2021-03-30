using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class FerramentaDB : IFerramentaDB
    {
        private static List<Ferramenta> lst = new List<Ferramenta>();

        public List<Ferramenta> GetAll()
        {
            var lstOut = new List<Ferramenta>();

            foreach (var item in lst)
            {
                lstOut.Add(item);
            }
            return lstOut;
        }

        public bool Insert(Ferramenta ferramenta)
        {
            lst.Add(ferramenta);
            return true;
        }

        public Ferramenta SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ferramenta ferramenta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
