using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.DTO
{
    public class CarInputDto
    {
            public string Make { get; set; }

            public string Model { get; set; }

            public int TravelledDistance { get; set; }

            public int[] PartsId { get; set; }
    }
}
