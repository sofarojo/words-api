using System.Collections.Generic;
using System.Linq;
using words_api.Models;

namespace words_api.Services
{
    public class WordsService
    {
        
        public IEnumerable<Word> GetAll() {
            IEnumerable<Word> words;

            using (var db = new WordsDbContext())
            {
                words = db.Words.OrderBy(x => x.Order).ToList();
            }

            return words;
        }

        public Word GetById(int id) {
            Word word;

            using (var db = new WordsDbContext())
            {
                word = db.Words.First<Word>(x=> x.WordId == id);   
            }

            return word;
        }

        public Word Add(Word word) {
            using (var db = new WordsDbContext())
            {
                db.Words.Add(word);
                db.SaveChanges();
                return word;
            }  
        }

        public Word Update(Word word) {
            using (var db = new WordsDbContext())
            {
                db.Words.Update(word);
                db.SaveChanges();
                return word;
            }   
        }

        public bool Delete(int id) {
            using (var db = new WordsDbContext())
            {
                if (db.Words.Count(t => t.WordId == id) > 0)
                {
                    db.Words.Remove(db.Words.First(t => t.WordId == id));
                    db.SaveChanges();
                    return true;
                } else {
                    return false;
                }
            }
        }
    }
}