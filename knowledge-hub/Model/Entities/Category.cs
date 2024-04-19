using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace knowledge_hub.Model.Entities;

[Index("CategoryName", Name = "UQ__Categori__8517B2E08A89C066", IsUnique = true)]
public partial class Category
{
    [Key]
    [Column("CategoryID")]
    public int CategoryId { get; set; }

    [StringLength(50)]
    public string? CategoryName { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Categories")]
    public virtual ICollection<Book> BookIsbns { get; set; } = new List<Book>();
}
