// Models/User.cs
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string PasswordHash { get; set; } // Store hashed password

    [Required]
    public string Role { get; set; } // Role can be "admin" or "guest"
}


