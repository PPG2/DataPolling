using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validation
{
    public interface IValidationCore
    {
        public bool IsValidateSuccesfuly(Bett bett);
    }
}
