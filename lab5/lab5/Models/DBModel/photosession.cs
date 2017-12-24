namespace lab5.Models.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("photosession")]
    public partial class photosession
    {
        public Guid Id { get; set; }

        [Required]
        public string Type_photo { get; set; }

        public decimal? Price { get; set; }

        public string Duration { get; set; }

        public int? Photo_amount { get; set; }

        public string Deadline { get; set; }
    }
}
