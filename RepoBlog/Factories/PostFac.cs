using System.Collections.Generic;
using RepoBlog.Models.BaseModels;
using RepoBlog.Models.ViewModels;

namespace RepoBlog.Factories
{
    public class PostFac : AutoFac<Post>
    {
        BilledeFac billedeFac = new BilledeFac();
        public List<BlogIndex> GetIndexData()
        {
            List<BlogIndex> listBlogIndex = new List<BlogIndex>();
            foreach (var post in GetAll())
            {
                BlogIndex blogIndex = new BlogIndex();

                blogIndex.post = post;
                blogIndex.billeder = billedeFac.GetBy("PostID", post.ID);

                listBlogIndex.Add(blogIndex);
            }

            return listBlogIndex;
        }
    }
}
