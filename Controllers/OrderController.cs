using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/news")]
    public class NewsController : ControllerBase
    {
        [HttpPut]
        public News Create(News news)
        {
            Storage.NewsStorage.Create(news);
            return news;
        }

        [HttpGet]
        public News Read(int newsId)
        {
            return Storage.NewsStorage.Read(newsId);
        }

        [HttpPatch]
        public News Update(int newsId, News newNews)
        {
            return Storage.NewsStorage.Update(newsId, newNews);
        }

        [HttpDelete]
        public bool Delete(int newsId)
        {
            return Storage.NewsStorage.Delete(newsId);
        }
    }
}