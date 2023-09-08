using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ox4sDatabase.Server.Services;
using ox4sDatabase.Shared;

namespace ox4sDatabase.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ArticlesController> _logger;
        private readonly DbContext _dbContext;

        public ArticlesController(ILogger<ArticlesController> logger, DbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<Article>> Get([FromQuery] PaginationService pagination)
        {
            var articles = _dbContext.Articles
                .Skip(pagination.Size * (pagination.Page - 1))
                .Take(pagination.Size);

            return await articles.ToListAsync();
        }

      
    }
}