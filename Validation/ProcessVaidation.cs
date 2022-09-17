using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace Validation
{
    public class ProcessVaidation : IprocessVaidation
    {
        private readonly IFactoryCreator? _factory;

        public ProcessVaidation( IServiceProvider serviceProvider)
        {
            _factory = serviceProvider.GetService<IFactoryCreator>();
        }
        public bool DoValidation(Bett bett)
        {
            var insatne= _factory.GetMatchInstance(bett.match);

            if(insatne.DoValidate(bett.match))
            {
                _factory.GetSportsInstance(bett.Sport);
            }
            return true;
        }
    }
}
