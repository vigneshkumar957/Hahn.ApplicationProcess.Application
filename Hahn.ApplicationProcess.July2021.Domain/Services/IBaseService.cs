using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicationProcess.July2021.Domain.Services
{
    public interface IBaseService<T>
    {
        T Find(int Id);
        List<T> GetAll();
        bool Delete(T Item);
    }
}
