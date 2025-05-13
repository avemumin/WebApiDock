using WebApiDock.Data;
using WebApiDock.Entity;

namespace WebApiDock
{
  public class UserSeeder
  {
    private readonly DataContext _dataContext;

    public UserSeeder(DataContext dataContext)
    {
      _dataContext = dataContext;
    }


    public void UserSeed()
    {
      if (!this._dataContext.Users.Any())
      {
        IEnumerable<User> u = Users();
        this._dataContext.Users.AddRange(u);
        this._dataContext.SaveChanges();
      }
    }

    private IEnumerable<User> Users()
    {
      var users = new List<User>()
      {
        new User(){ Name = "Staś", LastName = "Szczepański", Email="fistahstah@majster.pl"},
        new User(){Name = "Malwinka", LastName = "Szczepańska", Email = "mysiabula@majster.pl"}
      };
      return users;
    }
  }
}
