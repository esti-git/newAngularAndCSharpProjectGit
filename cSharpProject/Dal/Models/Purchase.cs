using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class Purchase
{
    [Key]
    [Column("purchase_id")]
    public int PurchaseId { get; set; }

    [Column("customer_id")]
    public int? CustomerId { get; set; }

    [Column("purchase_date", TypeName = "datetime")]
    public DateTime? PurchaseDate { get; set; }

    [Column("total_amount", TypeName = "decimal(10, 2)")]
    public decimal TotalAmount { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Purchases")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("Purchase")]
    public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
}
