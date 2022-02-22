using LinkShortener.Data;
using LinkShortener.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LinkShortener.Services
{
    public class LinkService
    {
        private LinkContext _context;
        private static Random random = new Random();
        public LinkService(LinkContext linkContext)
        {
            _context = linkContext;
        }

        public Link CreateShortLink(string originalLink)
        {           
            string shortLinkCode = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz0123456789", 5).Select(s => s[random.Next(s.Length)]).ToArray());
            Link link = new Link(originalLink, shortLinkCode);
            _context.Links.Add(link);
            _context.SaveChanges();
            return link;
        }
    }
}
