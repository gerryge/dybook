using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Users;

namespace Acme.Dybook.Users
{
    public class DyUserSynchronizer :
        IDistributedEventHandler<EntityUpdatedEto<DyUserEto>>,
        ITransientDependency
    {
        protected IDyUserRepository UserRepository { get; }

        protected IDyUserLookupService UserLookupService { get; }

        public DyUserSynchronizer(
            IDyUserRepository userRepository,
            IDyUserLookupService userLookupService)
        {
            UserRepository = userRepository;
            UserLookupService = userLookupService;
        }

        public virtual async Task HandleEventAsync(EntityUpdatedEto<DyUserEto> eventData)
        {
            var user = await UserRepository.FindAsync(eventData.Entity.Id);
            if (user == null)
            {
                user = await UserLookupService.FindByIdAsync(eventData.Entity.Id);
                if (user == null)
                {
                    return;
                }
            }

            if (user.Update(eventData.Entity))
            {
                await UserRepository.UpdateAsync(user);
            }
        }
    }
}
