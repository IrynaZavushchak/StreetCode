﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streetcode.DAL.Entities.Partners;

[Table("partner_source_links", Schema = "partners")]
public class PartnerSourceLink
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Title { get; set; }

    [Required]
    public string LogoUrl { get; set; }

    [Required]
    public string TargetUrl { get; set; }

    [Required]
    public int PartnerId { get; set; }

    public Partner? Partner { get; set; }
}