﻿using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Model
{
    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = String.Empty;
        [MaxLength(200)]
        public string? Description { get; set; }
    }
}