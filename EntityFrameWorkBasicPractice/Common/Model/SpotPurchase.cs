using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkBasicPractice;

[Table("SpotPurchase")]
public partial class SpotPurchase
{
    [Key]
    [Column("SPoId")]
    public int SpoId { get; set; }

    [Column("SPoNo")]
    [StringLength(10)]
    public string? SpoNo { get; set; }
}
