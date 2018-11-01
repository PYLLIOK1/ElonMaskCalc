using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class CalcController : Controller
    {
        private Core.Calc Calc { get; set; }
        // GET: Calc
        public ActionResult Execute(string operand, string oper)
        {
            Calc = new Core.Calc();
            string[] Operarions = Calc.Operations
                .Select(o => o.Name)
                .ToArray();
            var values = operand.Split(' ').Select(Convert.ToDouble).ToArray();
            var result = Calc.Execute(oper, values);
            ViewBag.Вася = $"Результат: {result}";
            return View();
        }
    }
}