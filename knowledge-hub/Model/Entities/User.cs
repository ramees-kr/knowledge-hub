using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace knowledge_hub.Model.Entities;

[Index("Username", Name = "UQ__Users__536C85E44B4A2134", IsUnique = true)]
public partial class User
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    public string? Username { get; set; }

    [StringLength(255)]
    public string? Password { get; set; }

    [StringLength(50)]
    public string? UserType { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? ContactDetails { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Fine> Fines { get; set; } = new List<Fine>();

    [InverseProperty("User")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [InverseProperty("User")]
    public virtual ICollection<UserFine> UserFines { get; set; } = new List<UserFine>();

    //public override string ToString() to display user details
    public override string ToString()
    {
        return $"User ID: {UserId}, Username: {Username}, Name: {Name}, Contact Details: {ContactDetails}";
    }
}
