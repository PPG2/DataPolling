using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.MatchValidation;
using Validation.SportsValidation;

namespace Validation
{
    public class FactoryCreator : IFactoryCreator
    {

        public BaseSportsValidate GetSportsInstance(Sport sport)
        {
           return  new FootBallValidation();
        }

        public BaseMatchValidae GetMatchInstance( Event @event )
        {
            return new LiveMatchValidation();
        }
    }
}
