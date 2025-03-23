using System;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;

namespace Infrastructure.Services;

public class UserService : IUserService
{
    private readonly LibraryDbContext _context;

    public UserService(LibraryDbContext context)
    {
        _context = context;
    }
    public async Task<User> GetUser(string email, string password)
    {
        User user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        return user;
    }

    public async Task<User> GetUser(string username)
    {
       return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
    }

    public async Task<User> SaveUser(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }
}
