using System;
using SimpleFlashCardApi.Data;
using SimpleFlashCardApi.Interfaces;
using SimpleFlashCardApi.Models;

namespace SimpleFlashCardApi.Repository;

public class UserRepository(AppDbContext context) : IUserRepository
{
    private readonly AppDbContext _context = context;

    public IEnumerable<User> GetUsers()
    {
        return _context.Users.OrderBy(user => user.Id).ToList();
    }
    public User GetUser(int userId)
    {
        return _context.Users.Where(user => user.Id == userId).FirstOrDefault();
    }

    public bool IsExists(int userId)
    {
        return _context.Users.Any(user => user.Id == userId);
    }
}
