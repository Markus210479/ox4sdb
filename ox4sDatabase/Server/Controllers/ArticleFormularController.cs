using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ox4sDatabase.Shared;


namespace ox4sDatabase.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleFormularController : Controller
    {
        private readonly DbContext _dbContext;

        public ArticleFormularController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<int> Post(List<Article> articles)
        {
            foreach (var article in articles) await _dbContext.Articles.AddAsync(article);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
