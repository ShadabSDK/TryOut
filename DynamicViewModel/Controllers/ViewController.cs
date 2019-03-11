using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicViewModel.Presentation;
using Microsoft.AspNetCore.Mvc;

namespace DynamicViewModel.Controllers
{
    [Route("api/view/{vmTypeName}")]
    public class ViewController : Controller
    {
        private readonly IViewModelFactory _viewModelFactory;
        public ViewController(IViewModelFactory viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        [HttpGet]
        public async Task<ActionResult> Get(string vmTypeName)
        {
            ViewContext viewContext = new ViewContext(HttpContext);

            IViewModel vm = _viewModelFactory.Create(vmTypeName, GetArgumentsFromRequestQuery());

            if (vm != null)
                viewContext.Items.Add(nameof(IViewModel), vm.GetType());
            else
                return NotFound();


            try
            {
                return Ok(await vm.);
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
        }

        private IDictionary<string, string> GetArgumentsFromRequestQuery()
        {
            return Request.Query
                .Select(kvp => new KeyValuePair<string, string>(kvp.Key, kvp.Value.ToString()))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }


    }
}