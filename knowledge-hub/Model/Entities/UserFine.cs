using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace knowledge_hub.Model.Entities;

public partial class UserFine
{
    [Key]
    [Column("UserFineID")]
    public int UserFineId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("FineID")]
    public int? FineId { get; set; }

    [ForeignKey("FineId")]
    [InverseProperty("UserFines")]
    public virtual Fine? Fine { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserFines")]
    public virtual User? User { get; set; }
}
