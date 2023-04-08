using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQuanLyKMServices
    {
        bool Add(Promotion obj);
        bool Update(Promotion obj);
        bool Delete(Promotion obj);
        List<Promotion> GetAll();
    }
}

