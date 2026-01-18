using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleFlashCardApi.Models;

namespace SimpleFlashCardApi.Data;

public class DbSeeder
{
    public static void SeedUser(AppDbContext context)
    {
        if (context.Users.Any())
        {
            return;
        }

        var passwordHasher = new PasswordHasher<string>();
        string hashedPassword = passwordHasher.HashPassword("user","user123");

        var users = new User[]
        {
            new() {
                Username ="Mavl28",
                Password = hashedPassword,
                FirstName = "Maulana"      
            },
            new()
            {
                Username ="Hoshiyomi",
                Password = hashedPassword,
                FirstName = "Suisei",
                LastName = "Hoshimaachi"   
            }
        };

        context.Users.AddRange(users);
        context.SaveChanges();
    }

}
