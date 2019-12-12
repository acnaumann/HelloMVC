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
                "<input type='submit' value='Greet!'/>" +
                "</form>";

            return Content(html, "text/html");
            //return redirect("/Hello/Goodbye");  (redirects to /Hello/Goodbye with the "goodbye" message)

        }

        // /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}<h1>", name), "text/html");
        }

        //Handle requests to /Hello/NAME (NAME = called URL segment - use as params that are passed )
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}<h1>", name), "text/html");
        }

        public Ia
        
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
