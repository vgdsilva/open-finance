using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using OpenFinance.Domain.Abstractions;
using OpenFinance.Domain.Attributes;

namespace OpenFinance.Domain.Entities;

[AuditLog(Create = true, Update = true, Delete = true)]
[Table("application_user")]
[Index(nameof(Login), IsUnique = true)]
[Index(nameof(Email), IsUnique = true)]
[Index(nameof(Name))]
[Index(nameof(IsEnabled))]
public partial class ApplicationUser : EntityControl
{
    [Required]
    [Column("login")]
    [StringLength(320)]
    public string Login { get; set; }

    [Required]
    [Column("name")]
    [StringLength(80)]
    public string Name { get; set; }

    [Required]
    [Column("password")]
    [StringLength(30)]
    public string Password { get; set; } = "";

    [Column("email")]
    [StringLength(80)]
    public string Email { get; set; }

    [Column("admin", TypeName = "boolean")]
    public bool IsAdmin { get; set; }

    [Column("profile_image", TypeName = "bytea")]
    public byte[] ProfileImage { get; set; }

    [Column("enabled", TypeName = "boolean")]
    public bool IsEnabled { get; set; } = true;



    public static ApplicationUser Create(string login, string name, string password, string email, bool isAdmin = false, byte[] profileImage = null, bool isEnabled = true)
    {
        return new ApplicationUser
        {
            Login = login,
            Name = name,
            Password = password,
            Email = email,
            IsAdmin = isAdmin,
            ProfileImage = profileImage,
            IsEnabled = isEnabled
        };
    }
}
