﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streetcode.DAL.Entities.Media;

[Table("videos", Schema = "media")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)] 
    public string? Title { get; set; }
    
    public string? Description { get; set; }

    [Required] 
    public string Url { get; set; }

    [Required]
    public int StreetcodeId { get; set; }

    public Streetcode.Streetcode? Streetcode { get; set; }
}
