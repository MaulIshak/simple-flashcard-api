using System;

namespace SimpleFlashCardApi.Dto;

public class UserDto
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
}
