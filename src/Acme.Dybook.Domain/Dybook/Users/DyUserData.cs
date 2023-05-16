using Volo.Abp.Users;

namespace Acme.Dybook.Users;

public class DyUserData: UserData, IDyUserData
{
    public string SocialSecurityNumber { get; }
}