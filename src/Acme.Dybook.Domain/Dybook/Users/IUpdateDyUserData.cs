using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Dybook.Users
{
    public interface IUpdateDyUserData
    {
        bool Update([NotNull] IDyUserData user);
    }
}
