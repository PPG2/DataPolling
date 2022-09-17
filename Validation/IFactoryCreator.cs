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
    public interface IFactoryCreator
    {
        public BaseSportsValidate GetSportsInstance(Sport sport);
        public BaseMatchValidae GetMatchInstance( Event @event );
    }
}
