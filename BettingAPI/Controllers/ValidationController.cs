using Core.Validation;
using Microsoft.AspNetCore.Mvc;

namespace BettingAPI.Controllers
{
    public class ValidationController : Controller
    {

        private readonly ILogger<ValidationController> _logger;
        private readonly IValidationCore? _validationCore;

        public ValidationController(ILogger<ValidationController> logger,IServiceProvider serviceProvider)
        {
            _logger = logger;
            _validationCore = serviceProvider.GetService<IValidationCore>();
        }
        
        //public bool Validate()
        //{
        //    return View();
        //}

    }
}
