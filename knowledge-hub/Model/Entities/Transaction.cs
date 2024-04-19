using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace knowledge_hub.Model.Entities;

public partial class Transaction
{
    [Key]
    [Column("TransactionID")]
    public int TransactionId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("BookISBN")]
    [StringLength(13)]
    [Unicode(false)]
    public string? BookIsbn { get; set; }

    [StringLength(50)]
    public string? TransactionType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [ForeignKey("BookIsbn")]
    [InverseProperty("Transactions")]
    public virtual Book? BookIsbnNavigation { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Transactions")]
    public virtual User? User { get; set; }
}
