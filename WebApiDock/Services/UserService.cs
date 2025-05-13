using Microsoft.EntityFrameworkCore;
using WebApiDock.Data;
using WebApiDock.Entity;
using WebApiDock.Services.Interfaces;

namespace WebApiDock.Services;

public class UserService : IUserService
{
  private readonly DataContext _dataContext;

  public UserService(DataContext dataContext)
  {
    _dataContext = dataContext;
  }

  public async Task<IEnumerable<User>> GetAsync()
  {
    var users = await _dataContext.Users.ToListAsync();
    return users;
  }

  public async Task<User> GetByIdAsync(int id)
  {
    var user = await _dataContext.Users.FirstOrDefaultAsync(u => u.Id == id);
    return user;
  }
}
