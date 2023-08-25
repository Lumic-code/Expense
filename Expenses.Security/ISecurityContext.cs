using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Security
{
    public interface ISecurityContext
    {
        User User { get; }
        bool IsAdminstrator { get; }
    }
}
