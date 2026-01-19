using System;
using SimpleFlashCardApi.Models;

namespace SimpleFlashCardApi.Interfaces;

public interface IUserRepository
{
    IEnumerable<User> GetUsers();
}
