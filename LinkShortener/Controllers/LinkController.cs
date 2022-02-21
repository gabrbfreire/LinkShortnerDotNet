using LinkShortener.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortener.Controllers
{
    [ApiController]
    [Route("/")]
    public class LinkController : ControllerBase
    {
        private readonly ILogger<LinkController> _logger;

        public LinkController(ILogger<LinkController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult ShortenLink([FromBody] CreateShortLinkDto originalLink)
        {
            return Ok("лол");
        }

        [HttpGet]
        public IActionResult GetOriginalLink([FromRoute] String linkId)
        {
            return Ok("лол");
        }
    }
}
