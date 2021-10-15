using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EventBus;
using Volo.Abp.Users;

namespace Acme.Dybook.Users
{
    //[EventName("Volo.Abp.Users.User")]
    public class DyUserEto : UserEto, IDyUserData
    {
        public string SocialSecurityNumber { get; set; }
    }
}
