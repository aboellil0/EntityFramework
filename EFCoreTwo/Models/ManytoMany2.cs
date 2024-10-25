using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTwoN.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
        public List<PostTag> PostTags { get; set; }
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public List<PostTag> PostTags { get; set; }
    }

    public class PostTag
    {
        public int PostForeignKey { get; set; }
        public int TagForeignKey { get; set; }
        public DateTime DateTime { get; set; }
        public Post Post { get; set; } 
        public Tag Tag { get; set; }
    }
}
