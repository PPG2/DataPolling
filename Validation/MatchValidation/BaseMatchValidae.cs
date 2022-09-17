using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.MatchValidation
{
    public abstract class BaseMatchValidae
    {
        public virtual bool DoValidate(Event even)
        {
            return true;
        }
    }
}
