using Volo.Abp.Users;

namespace Acme.Dybook.Users;

public class DyUserEto: UserEto, IDyUserData
{
    public string SocialSecurityNumber { get; set; }
}