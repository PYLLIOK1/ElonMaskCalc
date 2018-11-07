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
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Макс\Desktop\Курсы\1\ElonMaskCalc\EM.Calc.Web\App_Data\ElonMusk.mdf;Integrated Security=True";

            ResultOperationRepository ResultOperationRepository;

        public ResultOperationController()
        {
            ResultOperationRepository = new ResultOperationRepository(connString);
        }
            public ActionResult Index()
            {
            ViewBag.Hol = ResultOperationRepository.GetAll();
            return View();
            }
    }
}