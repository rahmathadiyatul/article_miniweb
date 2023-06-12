using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System;
using Article_MiniWeb._1_Core.Entities;

namespace Article_MiniWeb.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IConfiguration _config;
        public ArticleController(IArticleService articleService, IConfiguration config)
        {
            this.articleService = articleService;
            _config = config;
        }

        [Route("Api/[controller]/")]
        [HttpPost]
        public async Task<ActionResult> CreateArticle(Posts article)
        {
            try
            {
                var result = await articleService.GetData(article);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        /*[Route("Api/[controller]/GetPakaianOrderByPrice")]
        [HttpGet]
        public async Task<ActionResult> GetPakaianOrderByPrice(string urutan)
        {
            try
            {
                var result = await pakaianService.GetDataOrderByPrice(urutan);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
    }
}
