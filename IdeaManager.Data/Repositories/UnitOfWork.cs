// IdeaManager.Data/Repositories/UnitOfWork.cs

using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using IdeaManager.Data.Db;
using System.Threading.Tasks;

namespace IdeaManager.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IdeaDbContext _context;

        public IRepository<Idea> IdeaRepository { get; }
        public IRepository<User> UserRepository { get; }

        public UnitOfWork(IdeaDbContext context, IRepository<Idea> ideaRepository, IRepository<User> userRepository)
        {
            _context = context;
            IdeaRepository = ideaRepository;
            UserRepository = userRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
