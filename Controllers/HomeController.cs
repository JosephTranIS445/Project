using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aboutme()
        {
            return View();
        }

        public ActionResult Webform()
        {
            return View();
        }

        public ActionResult Absolute()
        {
            return View();
        }
        public ActionResult ClientSideDemo()
        {
            return View();
        }
        public ActionResult Float()
        {
            return View();
        }
        public ActionResult ServerSideDemo()
        {
            return View();
        }
        public ActionResult Static()
        {
            return View();
        }

        // Start of formatting number
        public ActionResult FormatPhoneNumber(string inputNumber)
        {

            if (string.IsNullOrEmpty(inputNumber))
            {
                return Content("invalid input, please try again");
            }
            else if (inputNumber.Length != 10)
            {
                return Content("Please input a 10 Digit phone number");
            }
            else
            {

                string formatted = formatNumber(inputNumber);
                return View((object)formatted);
            }
        }

      
        private string formatNumber(string inputNumber)
        {

            var first = inputNumber.Substring(0, 3);
            var second = inputNumber.Substring(3, 3);
            var third = inputNumber.Substring(6, 4);

            return "(" + first + ") " + second + "-" + third;
        }

        /*end of Formatting a phone number*/

        public ActionResult ReverseQuestion()
        {
            return View();
        }

        public ActionResult PhraseReverse(string phase)
        {

            var word = phase;
            var result = string.Join(" ", word.Split(' ').Reverse());

     


            return View((object)result);
        }
    }
}
