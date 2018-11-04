using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM.Calc.Web.Models;

namespace EM.Calc.Web.Controllers
{
    public class CalcController : Controller
    {
        private Core.Calc calc;
        private IEnumerable<SelectListItem> GetSelectListItems()
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();
            foreach (var element in calc.Operations)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Name,
                    Text = element.Name
                });
            }
            return selectList;
        }
        public CalcController()
        {
            calc = new Core.Calc(@"E:\");
        }
        private OperationResult Calc(string oper, double[] args)
        {
            var result = calc.Execute(oper, args);

            return new OperationResult()
            {
                Name = oper,
                Result = result
            };
        }
        public ActionResult Execute(string oper, double[] args)
        {
            var model = Calc(oper, args);

            return View(model);
        }
        [HttpGet]
        public ActionResult Input()
        {
            var model = new InputModel
            {
                States = GetSelectListItems()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Input(InputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = Calc(model.Name, model.Args1);

            return View("Execute", result);
        }
    }
}