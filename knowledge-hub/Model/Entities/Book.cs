using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace knowledge_hub.Model.Entities;

public partial class Book
{
    [Key]
    [Column("ISBN")]
    [StringLength(13)]
    [Unicode(false)]
    public string Isbn { get; set; } = null!;

    [StringLength(255)]
    public string? Title { get; set; }

    [StringLength(255)]
    public string? Author { get; set; }

    public int? YearOfPublication { get; set; }

    [StringLength(255)]
    public string? Publisher { get; set; }

    [Column("ImageURLSmall")]
    [StringLength(255)]
    public string? ImageUrlsmall { get; set; }

    [Column("ImageURLMedium")]
    [StringLength(255)]
    public string? ImageUrlmedium { get; set; }

    [Column("ImageURLLarge")]
    [StringLength(255)]
    public string? ImageUrllarge { get; set; }

    public bool? Available { get; set; }

    [InverseProperty("BookIsbnNavigation")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [ForeignKey("BookIsbn")]
    [InverseProperty("BookIsbns")]
    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    //Override the ToString method to return the book title
    public override string ToString()
    {
        //return all book details
        return $"{Title} by {Author} published by {Publisher} in {YearOfPublication}";
    }
}
