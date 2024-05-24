using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paper.Storage.Interfaces;

namespace Paper.Storage.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<bool> RegisterNewUser()
        {
            throw new NotImplementedException();
        }
    }
}
