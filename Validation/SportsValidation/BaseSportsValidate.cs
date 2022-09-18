using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.SportsValidation
{
    public abstract class BaseSportsValidate
    {

      public virtual bool DoSportsvalidation()
      {
            return true;
      }
        public bool GetSportsRules()
        {
            return true;
        }
    }
}
