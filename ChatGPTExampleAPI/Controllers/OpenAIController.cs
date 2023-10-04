using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatGPTExampleAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenAI_API.Moderation;

namespace ChatGPTExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenAIController : ControllerBase
    {
        private readonly ILogger<OpenAIController> _logger;
        private readonly IOpenAIService _openAıService;

        public OpenAIController(
            ILogger<OpenAIController> logger,
            IOpenAIService openAıService)
        {
            _logger = logger;
            _openAıService = openAıService;
        }

        [HttpPost]
        public async Task<IActionResult> ComplateSentence(string text)
        {
            var result = await _openAıService.ComplateSentece(text);
            return Ok(result);
        }
    }
}
