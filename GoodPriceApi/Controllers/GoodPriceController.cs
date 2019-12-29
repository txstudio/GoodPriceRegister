using System.Threading.Tasks;
using GoodPriceApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoodPriceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class GoodPriceController : ControllerBase
    {
        private readonly GoodPriceService _service;
        private readonly ILogger<GoodPriceController> _logger;

        public GoodPriceController(GoodPriceService service
                                , ILogger<GoodPriceController> logger)
        {
            this._service = service;
            this._logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync()
        {
            var _results = await this._service.GetListAsync();

            return Ok(_results);
        }
    }
}
