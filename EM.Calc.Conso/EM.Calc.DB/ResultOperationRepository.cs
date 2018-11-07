using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EM.Calc.DB
{
    public class ResultOperationRepository : BaseRepository<ResultOperation>
    {
        public ResultOperationRepository(string connectionString) : base(connectionString)
        {
        }

        public override string TableName { get => "ResultOperation"; }

    }
}
