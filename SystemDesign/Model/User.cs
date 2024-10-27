using System;

namespace Model;

public class User
{
    public string Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public DateTime RegisteredAt { get; set; }
    public DateTime LastLoginAt { get; set; }
    public bool IsAdmin { get; set; }
    public string About { get; set; }
    public string Language { get; set; }
    public string Theme { get; set; }
}