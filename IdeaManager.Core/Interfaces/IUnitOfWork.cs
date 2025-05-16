using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace IdeaManager.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Idea> IdeaRepository { get; }
        IRepository<User> UserRepository { get; }

        Task<int> SaveChangesAsync();
    }
}
