using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM.Calc.DB;

namespace EM.Calc.Web.Controllers
{
    public class ResultOperationController : Controller
    {
        IEntityRepository<OperationResult> OperationResultRepository;

        public ResultOperationController()
        {
            OperationResultRepository = new NHOperationResultRepository();
        }

        // GET: OperationResult
        public ActionResult Index()
        {
            var all = OperationResultRepository.GetAll();

            return View(all);
        }
    }
}