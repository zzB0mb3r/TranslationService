using Microsoft.AspNetCore.Mvc;
using TranslationService.Domain.Models;
using TranslationService.Domain.Services;

namespace TranslationService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TranslationController : Controller
    {
        private readonly ITranslationsService _translationService;

        public TranslationController(ITranslationsService translationService)
        {
            _translationService = translationService;
        }

        [HttpPost("translate")]
        public async Task<IActionResult> Translate([FromBody] TranslationModel model)
        {
            try
            {
                var response = await _translationService.TranslateAsync(model);
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ooops! Something went wrong");
            }
        }
    }
}
