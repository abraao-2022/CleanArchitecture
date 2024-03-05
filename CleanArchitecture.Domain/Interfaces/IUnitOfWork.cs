using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1CleanArchitecture.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken);
    }
}