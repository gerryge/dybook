using Acme.Dybook.Users;
using AutoMapper;
using Volo.Abp.Data;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace Dyabp.DyProjectName
{
    public class DybookDomainAutoMapperProfile : Profile
    {
        public DybookDomainAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<IdentityUser, DyUserEto>()
                .ForMember(x => x.SocialSecurityNumber, map => map.MapFrom(user => user.GetProperty("SocialSecurityNumber", null)));
            CreateMap<UserData, DyUserData>();
        }
    }
}
