using Expenses.Data.Access.DAL;
using Expenses.Queries.Processor;
using Expenses.Security;
using Moq;
using System.Configuration;

namespace Expenses.Queries.Tests
{
    public class ExpensesQueryProcessorTests
    {
        private Mock<IUnitOfWork> _uow;
        private List<Expenses> _expenseList;
        private ExpensesQueryProcessor _query;
        private Random _random;
        private User _currentUser;
        private Mock<ISecurityContext> _securityContext;
    }
}