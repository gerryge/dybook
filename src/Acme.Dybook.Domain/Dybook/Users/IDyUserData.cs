using JetBrains.Annotations;
using Volo.Abp.Users;

namespace Acme.Dybook.Users;

public interface IDyUserData:IUserData
{
    [CanBeNull]
    string SocialSecurityNumber { get; }
}