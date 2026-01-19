using System;
using SimpleFlashCardApi.Models;

namespace SimpleFlashCardApi.Interfaces;

public interface IUserRepository
{
    IEnumerable<User> GetUsers();
    User GetUser(int userId);
    bool IsExists(int userId);
}
