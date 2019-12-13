using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {

            string html = "<form method='post'>" +
                "<input type='text' name='name'/>" +
                "<select name='language' id='language-select'>" +
                "<option value=''>Please choose an option</option>" +
                "<option value='English'>English</option>" +
                "<option value='German'>German</option>" +
                "<option value='French'>French</option>" +
                "<option value='Spanish'>Spanish</option>" +
                "<option value='Czech'>Czech</option>" +
                "</select>" +
                "<input type='submit' value='Greet!'/>" +
                "</form>";

            return Content(html, "text/html");
            //return redirect("/Hello/Goodbye");  (redirects to /Hello/Goodbye with the "goodbye" message)

        }

        // /Hello
        //[Route("/Hello")]
        //[HttpPost]
        //public IActionResult Display(string name = "World")
        //{
        //    return Content(string.Format("<h1>Hello {0}<h1>", name), "text/html");
        //}

        ////Handle requests to /Hello/NAME (NAME = called URL segment - use as params that are passed )
        //[Route("/Hello/{name}")]
        //public IActionResult Index2(string name)
        //{
        //    return Content(string.Format("<h1>Hello {0}<h1>", name), "text/html");
        //}

        
        //public IActionResult Goodbye()
        //{
        //    return Content("Goodbye");
        //}


        [Route("/Hello")]
        [HttpPost]
        public IActionResult CreateMessage(string language, string name)
        {
            if (language == "English")
            {
                return Content(string.Format("Hello {0}", name));
            }
            else if (language == "Spanish")
            {
                return Content(string.Format("Hola {0}", name));
            }
            else if (language == "German")
            {
                return Content(string.Format("Hallo {0}", name + "! Wie geht's?"));
            }
            else if (language == "French")
            {
                return Content(string.Format("Bonjour {0}", name));
            }
            else if (language == "Czech")
            {
                return Content(string.Format("Ahoj {0}", name));
            }

            else
            {
                return null;
            }


            
        }
    }
}
