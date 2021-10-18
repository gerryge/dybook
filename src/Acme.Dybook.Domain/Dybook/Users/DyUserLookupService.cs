using Volo.Abp.ObjectMapping;
using Volo.Abp.Uow;
using Volo.Abp.Users;

namespace Acme.Dybook.Users
{
    public class DyUserLookupService : UserLookupService<DyUser, IDyUserRepository>, IDyUserLookupService
    {
        protected IObjectMapper<DybookDomainModule> ObjectMapper { get; }
        public DyUserLookupService(
            IDyUserRepository userRepository,
            IUnitOfWorkManager unitOfWorkManager,
             IObjectMapper<DybookDomainModule> objectMapper)
            : base(
                userRepository,
                unitOfWorkManager)
        {
            ObjectMapper = objectMapper;
        }

        protected override DyUser CreateUser(IUserData externalUser)
        {
            var user = ObjectMapper.Map<UserData, DyUserData>((UserData)externalUser);
            return new DyUser(user);
        }
    }
}
