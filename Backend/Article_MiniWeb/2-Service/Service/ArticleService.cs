using Article_MiniWeb._1_Core.Entities;
using Article_MiniWeb._2_Service.Service.Interface;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Article_MiniWeb._2_Service.Service
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository articleRepository;
        private readonly MySqlConnection _db;
        public ArticleService(IArticleRepository articleRepository, IConfiguration configuration)
        {
            this.articleRepository = articleRepository;
            _db = new MySqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public async Task<bool> CreateArticle(Posts posts)
        {
            throw new System.NotImplementedException();
        }
    }
}
