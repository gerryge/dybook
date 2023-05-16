using Acme.Dybook.Users;
using AutoMapper;
using Volo.Abp.Data;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace Acme.Dybook;

public class DybookDomainAutoMapperProfile:Profile
{
    public DybookDomainAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization.
         * https://docs.abp.io/en/abp/latest/Object-To-Object-Mapping */
        // CreateMap<IdentityUser, DyUserEto>()
        //     .ForMember(x => x.SocialSecurityNumber, map => map.MapFrom(user => user.GetProperty("SocialSecurityNumber", null)));
        // CreateMap<UserData, DyUserData>();
        CreateMap<IdentityUser, UserEto>().MapExtraProperties();
    }
}