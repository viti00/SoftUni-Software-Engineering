using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Theatre.Data.Models.Enums;

namespace Theatre.Data.Models
{
    public class Play
    {
       
        public Play()
        {
            this.Tickets = new HashSet<Ticket>();
            this.Casts = new HashSet<Cast>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.playTitleMaxLenght)]
        public string Title { get; set; }

        public TimeSpan Duration { get; set; }

        public float Rating { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [MaxLength(GlobalConstants.descrtiptionMaxLenght)]
        public string Description { get; set; }

        [Required]
        [MaxLength(GlobalConstants.screenWriterMaxLenght)]
        public string Screenwriter { get; set; }

        public virtual ICollection<Cast> Casts { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
