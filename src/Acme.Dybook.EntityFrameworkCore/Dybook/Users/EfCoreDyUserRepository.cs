using Acme.Dybook.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Acme.Dybook.Users;

public class EfCoreDyUserRepository
    : EfCoreUserRepositoryBase<DybookDbContext, DyUser>, IDyUserRepository
{
    public EfCoreDyUserRepository(IDbContextProvider<DybookDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}