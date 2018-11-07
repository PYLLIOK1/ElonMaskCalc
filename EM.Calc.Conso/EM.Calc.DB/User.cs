using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.DB
{
    public class User : IEntity
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public DateTime? BirthDay { get; set; }

        public bool Sex { get; set; }
    }
}
