using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Users;

namespace Acme.Dybook.Users
{
    public interface IDyUser : IUser
    {
        string SocialSecurityNumber { get; }
    }
}
