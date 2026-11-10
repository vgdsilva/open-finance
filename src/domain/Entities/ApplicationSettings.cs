using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using OpenFinance.Domain.Abstractions;

namespace OpenFinance.Domain.Entities;

[Table("application_settings")]
[Index(nameof(Key))]
[Index(nameof(UserId))]
public partial class ApplicationSettings : EntityControl
{
    [Column("key")]
    [StringLength(255)]
    [Required]
    public required string Key { get; set; }

    [StringLength(8000)]
    [Column("value")]
    public string Value { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; } = null;


    public override string ToString()
    {
        return string.Format("Key: {0}, Value: {1}, UserId: {2}", Key, Value, UserId);
    }


    [ForeignKey(nameof(UserId))]
    public virtual ApplicationUser ApplicationUserEntity { get; set; }



    public static ApplicationSettings Create(string key, string value, Guid? userId = null)
    {
        return new ApplicationSettings
        {
            Key = key,
            Value = value,
            UserId = userId
        };
    }
}
