using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? DisplayName { get; set; }
        public required string BlogPost { get; set; }
        public ICollection<BlogPost>? BlogPosts { get; set; }
    }
}