using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using words_api.Models;
using words_api.Services;

namespace words_api.Controllers
{
    [Route("api/v1/words")]
    public class WordsController : Controller
    {
        [HttpGet]
        public IEnumerable<Word> Get()
        {
            WordsService service = new WordsService();
            return service.GetAll();
        }

        [HttpGet("{id}")]
        public Word Get(int id)
        {
            WordsService service = new WordsService();
            return service.GetById(id);
        }

        [HttpPost]
        public Word Post([FromBody]JObject value)
        {
            WordsService service = new WordsService();
            Word posted = value.ToObject<Word>();

            return service.Add(posted);
        }

        [HttpPut("{id}")]
        public Word Put(int id, [FromBody]JObject  value)
        {
            WordsService service = new WordsService();
            Word posted = value.ToObject<Word>();
            posted.WordId = id; // Ensure an id is attached

            return service.Update(posted);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            WordsService service = new WordsService();
            return service.Delete(id);
        }
    }
}
