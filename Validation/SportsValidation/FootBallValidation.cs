using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.SportsValidation
{
    internal class FootBallValidation :BaseSportsValidate
    {
        public override bool DoSportsvalidation()
        {
             if (base.DoSportsvalidation() != false)
            {
                //Do logic
            }
            else
            {
                return false;
            }
             return false;
        }
    }
}
