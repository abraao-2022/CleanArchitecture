using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1CleanArchitecture.Domain.Entities;
using ClassLibrary1CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User> , IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> GetEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}