using Employee.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface IUserRepository : IRepository<DatingApp.Core.Entities.User>
    {
        //custom operations here
        Task<IEnumerable<DatingApp.Core.Entities.User>> GetEmployeeByLastName(string lastname);
    }
}
