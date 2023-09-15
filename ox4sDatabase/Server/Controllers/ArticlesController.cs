using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ox4sDatabase.Client.Pages;
using ox4sDatabase.Shared;
using PaginationService = ox4sDatabase.Shared.PaginationService;

namespace ox4sDatabase.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
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