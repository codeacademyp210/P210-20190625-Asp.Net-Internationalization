using MultiLang.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace MultiLang.Controllers
{
    public class HomeController : MainController
    {

        public ActionResult Index()
        {
            List<Translate> sozler = db.Translates.Where(t => t.Keyword == "Login" || t.Keyword == "Register").ToList();
            List<Word> words = new List<Word>();

            string cult = Thread.CurrentThread.CurrentUICulture.Name;
            if (cult == "en")
            {
                foreach (var item in sozler)
                {
                    Word word = new Word
                    {
                        Keyword = item.Keyword,
                        Value = item.En
                    };
                    words.Add(word);
                }
            } else if (cult == "az")
            {
                foreach (var item in sozler)
                {
                    Word word = new Word
                    {
                        Keyword = item.Keyword,
                        Value = item.Az
                    };
                    words.Add(word);
                }
            }
            

            return View(words);
        }


        [Authorize(Roles = "Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DiliDeyish(string dil)
        {
            new LanguageMang().SetLanguage(dil);
            return RedirectToAction("Index");
        }
    }
}