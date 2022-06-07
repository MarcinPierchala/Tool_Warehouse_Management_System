using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Queries;

namespace Tool_Warehouse_Management_System.DataAccess
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly ToolWarehouseStorageContext context;

        public QueryExecutor(ToolWarehouseStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(this.context);
        }
    }
}
