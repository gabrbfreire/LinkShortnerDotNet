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
        public int Id { get; set; }
        public string OriginalLink { get; set; }
        public string ShortLink { get; set; }
    }
}
