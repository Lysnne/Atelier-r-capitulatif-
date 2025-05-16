using IdeaManager.Core.Entities;

namespace IdeaManager.Core.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
    }
}
