using FineBlog.Models;
using X.PagedList;

namespace FineBlog.ViewModels
{
    public class HomeVM
    {
        public string? Title { get; set; }
        public string? ShortDesctiption { get; set; }
        public string? ThumbnailUrl { get; set; }
        public IPagedList<Post> Posts { get; set; }
    }
}
