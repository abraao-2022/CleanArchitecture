using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1CleanArchitecture.Domain.Entities;

namespace ClassLibrary1CleanArchitecture.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetEmail(string email, CancellationToken cancellationToken);
    }
}