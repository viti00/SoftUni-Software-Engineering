using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Theatre.DataProcessor.ImportDto
{
    public class TheatersImportDto
    {
        [Required]
        [MinLength(GlobalConstants.theatreNameMinLenght)]
        [MaxLength(GlobalConstants.theatreNameMaxLenght)]
        public string Name { get; set; }

        [Range(GlobalConstants.numberOfHallsMinRange, GlobalConstants.numberOfHallsMaxRange)]
        public sbyte NumberOfHalls { get; set; }

        [Required]
        [MinLength(GlobalConstants.theatreDirectorMinLenght)]
        [MaxLength(GlobalConstants.theatreDirectorMaxLenght)]
        public string Director { get; set; }

        public TheaterTicketsImportDto[] Tickets { get; set; }
    }
}
