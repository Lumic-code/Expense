using Expenses.Api.Models;
using Expenses.Data.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Queries.Processor
{
    public interface IExpenseQueryProcessor
    {
        IQueryable<Expense> Get();
        Expense Get(int id);
        Task<Expense> Create(CreateExpenseModel model);
        Task<Expense> Update(int id, UpdateExpenseModel model);
        Task Delete(int id);
    }
}
