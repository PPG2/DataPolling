using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Validation
{
    public class ValidationCore : IValidationCore
    {

        private readonly IprocessVaidation _validationCore;

        public ValidationCore(IServiceProvider serviceProvider)
        {
           
            _validationCore = serviceProvider.GetService<IprocessVaidation>();
        }
        public bool IsValidateSuccesfuly(Bett bett)
        {
           return _validationCore.DoValidation(bett);
        }
    }
}
