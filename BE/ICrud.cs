using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICrud<T>
    {
        bool Add(T entAlta);
        bool Update(T entUpd);
        bool Delete(T entDel);
        IList<T> GetAll();
       

        //T SelectById(T objSelect);

        bool Validar( T entVal);
    }
}
