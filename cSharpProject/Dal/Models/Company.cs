using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

[Index("CompanyName", Name = "UQ__Companie__6D1B87CBC254F0AE", IsUnique = true)]
public partial class Company
{
    [Key]
    [Column("company_id")]
    public int CompanyId { get; set; }

    [Column("company_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string CompanyName { get; set; } = null!;

    [Column("contact_email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ContactEmail { get; set; }

    [Column("phone")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
