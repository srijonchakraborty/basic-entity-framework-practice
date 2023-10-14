using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkBasicPractice;

[Table("Contact")]
public partial class Contact
{
    [Key]
    public int ContactId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PersonName { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PersonalMobile { get; set; }
}
