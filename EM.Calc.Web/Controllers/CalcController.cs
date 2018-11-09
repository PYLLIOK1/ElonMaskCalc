using EM.Calc.DB;
using EM.Calc.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class CalcController : Controller
    {
        private Core.Calc calc;
        IEntityRepository<Operation> nHOperationRepository;
        IEntityRepository<User> nHUserRepository;
        IEntityRepository<Calc.DB.ResultOperation> ResultOperationRepository;
        public CalcController()
        {
            nHOperationRepository = new NHOperationRepository();
            nHUserRepository = new NHUserRepository();
            ResultOperationRepository = new NHResultOperationRepository();
            calc = new Core.Calc(@"E:\");
        }
        private Models.OperationResult Calc(string oper, double[] args)
        {
            var result = calc.Execute(oper, args);
            var user = nHUserRepository.Load(3);
            var operation = nHOperationRepository.GetAll().FirstOrDefault(x =>x.Name==oper);
            var Oper = new Calc.DB.ResultOperation
            {
                UserId = 3,
                Operation = operation,
                User = user,
                ExecTime = new Random().Next(1, 1000),
                OperationId = operation.Id,
                CreationDate = DateTime.Now,
                Status = EM.Calc.DB.OperationResultStatus.DONE,
                Result = result ?? double.NaN,
                Args = string.Join(" ", args)
            };

            ResultOperationRepository.Save(Oper);

            return new Models.OperationResult()
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
                Operations = calc.Operations
            };
            return View(model);
        }
        [HttpPost]
        public PartialViewResult Input(InputModel model)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }

            if (!calc.Operations.Any(m => m.Name == model.Name))
            {
                ModelState.AddModelError("", "Такой операции нет");
                return null;
            }

            var result = Calc(model.Name, model.Args1);

            return PartialView("Execute", result);
        }

    }
}