using System.Reflection.Emit;
using BlogWebsite.Core.Entities;

namespace BlogWebsite.Models.Entities;

public sealed class Post : Entity<Guid>
{
   
    public string title { get; set; }
    public string Content { get; set; }
}