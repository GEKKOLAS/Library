using System;
using Core.Models;

namespace Infrastructure.Services;

public interface IUserService 
{
    Task<User> GetUser(string email, string password);
    Task<User> SaveUser(User user);
    Task<User> GetUser(string username);

}
