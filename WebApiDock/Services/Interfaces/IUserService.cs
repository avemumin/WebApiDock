using WebApiDock.Entity;

namespace WebApiDock.Services.Interfaces;

public interface IUserService
{
  Task<IEnumerable<User>> GetAsync();
  Task<User> GetByIdAsync(int id);
}
