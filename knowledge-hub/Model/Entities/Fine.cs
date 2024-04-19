using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace knowledge_hub.Model.Entities;

public partial class Fine
{
    [Key]
    [Column("FineID")]
    public int FineId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FineDate { get; set; }

    public bool? Paid { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Fines")]
    public virtual User? User { get; set; }

    [InverseProperty("Fine")]
    public virtual ICollection<UserFine> UserFines { get; set; } = new List<UserFine>();
}
