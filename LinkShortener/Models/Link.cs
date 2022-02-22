using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortener.Models
{
    public class Link
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string OriginalLink { get; set; }
        [Required]
        public string ShortLinkCode { get; set; }

        public Link(string originalLink, string shortLinkCode)
        {
            OriginalLink = originalLink;
            ShortLinkCode = shortLinkCode;
        }
    }
}
