using Volo.Abp.Uow;
using Volo.Abp.Users;

namespace Acme.Dybook.Users;

public class DyUserLookupService: UserLookupService<DyUser, IDyUserRepository>, IDyUserLookupService
{
    public DyUserLookupService(
        IDyUserRepository userRepository,
        IUnitOfWorkManager unitOfWorkManager)
        : base(
            userRepository,
            unitOfWorkManager)
    {

    }

    protected override DyUser CreateUser(IUserData externalUser)
    {
        return new DyUser(externalUser);
    }
}