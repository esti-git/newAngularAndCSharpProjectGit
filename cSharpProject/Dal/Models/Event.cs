using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class Event
{
    [Key]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("name")]
    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }

    [Column("event_date", TypeName = "datetime")]
    public DateTime EventDate { get; set; }

    [Column("location")]
    [StringLength(100)]
    [Unicode(false)]
    public string Location { get; set; } = null!;

    [Column("age_min")]
    public int? AgeMin { get; set; }

    [Column("category_id")]
    public int? CategoryId { get; set; }

    [Column("company_id")]
    public int? CompanyId { get; set; }

    [Column("price", TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public string? ImageUrl { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Events")]
    public virtual Category? Category { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Events")]
    public virtual Company? Company { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
}
