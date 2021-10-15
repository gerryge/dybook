using Acme.Dybook.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Acme.Dybook.Users
{
    public class EfCoreDyUserRepository : EfCoreUserRepositoryBase<DybookDbContext, DyUser>, IDyUserRepository
    {
        public EfCoreDyUserRepository(IDbContextProvider<DybookDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
