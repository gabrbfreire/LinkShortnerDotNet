using LinkShortener.Models;
using LinkShortener.Services;
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
        private LinkService _linkService;

        public LinkController(LinkService linkService)
        {
            _linkService = linkService;
        }

        [HttpPost]
        public IActionResult ShortenLink([FromBody] CreateShortLinkDto originalLink)
        {
            Link link = _linkService.CreateShortLink(originalLink.Link);
            return Created("https://localhost:5001/" + link.ShortLinkCode, link);
        }

        [HttpGet]
        [Route("/{linkId}")]
        public IActionResult GetOriginalLink([FromRoute] string linkId)
        {
            return Ok("лол");
        }
    }
}
