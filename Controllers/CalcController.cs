using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Index()
        {
            return View(new Calc());
        }

        [HttpPost]
        public ActionResult Index(Calc calculator, string calculate)
        {
            if (calculate == "div" && calculator.Number2 == 0)
            {
                calculator.Total = 0;
            }
            else
            {
                switch (calculate)
                {
                    case "add":
                        calculator.Total = calculator.Number1 + calculator.Number2;
                        break;
                    case "sub":
                        calculator.Total = calculator.Number1 - calculator.Number2;
                        break;
                    case "mult":
                        calculator.Total = calculator.Number1 * calculator.Number2;
                        break;
                    case "div":
                        calculator.Total = calculator.Number1 / calculator.Number2;
                        break;
                }
            }

            return View(calculator);
        }
    }
}

