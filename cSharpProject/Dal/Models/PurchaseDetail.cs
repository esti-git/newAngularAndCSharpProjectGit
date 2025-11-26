using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class PurchaseDetail
{
    [Key]
    [Column("detail_id")]
    public int DetailId { get; set; }

    [Column("purchase_id")]
    public int? PurchaseId { get; set; }

    [Column("product_id")]
    public int? ProductId { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("price", TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("PurchaseDetails")]
    public virtual Event? Product { get; set; }

    [ForeignKey("PurchaseId")]
    [InverseProperty("PurchaseDetails")]
    public virtual Purchase? Purchase { get; set; }
}
