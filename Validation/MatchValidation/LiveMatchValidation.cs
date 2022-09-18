using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.MatchValidation
{
    internal class LiveMatchValidation : BaseMatchValidae
    {
        public override bool DoValidate(Event even)
        {
            
            if(base.DoValidate(even)!=false)
            {
                //Do logic
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
