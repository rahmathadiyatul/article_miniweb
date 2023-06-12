using Article_MiniWeb._1_Core.Entities;
using System.Threading.Tasks;

namespace Article_MiniWeb._2_Service.Service.Interface
{
    public interface IArticleService
    {
        public Task<bool> CreateArticle(Posts posts);
    }
}
