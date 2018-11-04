using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EM.Calc.Web.Models
{
    public class InputModel
    {
        [Display(Name = "Операция")]
        [Required(ErrorMessage = "Нам обязательно нужно знать операцию")]
        public string Name { get; set; }

        [Display(Name = "Параметры")]
        public double[] Args1 { get; set; }
        public IEnumerable<SelectListItem> States { get; set; }
    }
}