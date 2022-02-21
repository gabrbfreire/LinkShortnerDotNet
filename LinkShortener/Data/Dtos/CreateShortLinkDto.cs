using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortener.Models
{
    public class CreateShortLinkDto
    {
        [Url(ErrorMessage = "Invalid URL")]
        [Required (ErrorMessage = "Missing URL")]
        public string Link { get; set; }
    }
}
