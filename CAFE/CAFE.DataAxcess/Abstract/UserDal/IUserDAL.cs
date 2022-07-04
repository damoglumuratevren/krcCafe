using CAFE.Entity.Concrete.UserEn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.DataAxcess.Abstract.UserDal
{
    public interface IUserDAL : IRepository<User>
    {
    }
}
