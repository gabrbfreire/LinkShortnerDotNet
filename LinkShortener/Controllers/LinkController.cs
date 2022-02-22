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
        private LinkService _service;

        public LinkController(LinkService linkService)
        {
            _service = linkService;
        }

        [HttpPost]
        public IActionResult ShortenLink([FromBody] CreateShortLinkDto originalLink)
        {
            Link link = _service.CreateShortLink(originalLink.Link);
            return Created("https://localhost:5001/" + link.ShortLinkCode, link);
        }

        [HttpGet]
        [Route("/{linkId}")]
        public IActionResult GetOriginalLink([FromRoute] string linkId)
        {
            if (linkId.All(char.IsLetterOrDigit))
            {
                try
                {
                    return Redirect(_service.GetOriginalLink(linkId));
                }
                catch(NullReferenceException)
                {
                    return NotFound();
                }
            }
            return BadRequest("Invalid link id");
        }
    }
}
