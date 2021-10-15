using Acme.Dybook.Users;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
            CreateMap<IdentityUser, DyUserEto>();
            //CreateMap<UserEto, DyUserEto>().ReverseMap();
        }
    }
}
