namespace BDHLProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamInfo")]
    public partial class TeamInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TeamName { get; set; }

        public int? Salary { get; set; }

        public int? LeagueStanding { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TeamAbbreviation { get; set; }
    }
}
