using Expenses.Api.Models;
using Expenses.Data.Model.Models;

namespace Expenses.Queries.Processor
{
    public class ExpensesQueryProcessor : IExpenseQueryProcessor
    {
        public Task<Expense> Create(CreateExpenseModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Expense> Get()
        {
            throw new NotImplementedException();
        }

        public Expense Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Expense> Update(int id, UpdateExpenseModel model)
        {
            throw new NotImplementedException();
        }
    }
}