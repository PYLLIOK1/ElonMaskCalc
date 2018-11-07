using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.DB
{
    public class ResultOperation : IEntity
    {
        public long Id { get; set; }

        public double Result { get; set; }

        public string Args { get; set; }

        public DateTime? CreationDate { get; set; }

        public int Status { get; set; }

        public long ExecTime { get; set; }

        public long UserId { get; set; }

        public long OperationId { get; set; }
    }
}
