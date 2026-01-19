using System;
using Npgsql.Replication;
using SimpleFlashCardApi.Dto;
using SimpleFlashCardApi.Models;

namespace SimpleFlashCardApi.Mappers;

public static class UserMappers
{
    public static UserDto ToUserDto(this User userModel) // Extension Method to User class
    {
        return new UserDto
        {
          Id = userModel.Id,
          Username = userModel.Username,
          FirstName = userModel.FirstName,
          LastName = userModel.LastName  
        };
    }
}
