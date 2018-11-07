using EM.Calc.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EM.Calc.Web.Models
{
    public class InputModel
    {
        public InputModel()
        {
            Operations = new List<IOperation>();
        }
        [Display(Name = "Операция")]
        [Required]
        public string Name { get ; set; }

        [Display(Name = "Параметры")]
        public double[] Args1 { get; set; }
        public IList<IOperation> Operations { get; set; }

    }
}