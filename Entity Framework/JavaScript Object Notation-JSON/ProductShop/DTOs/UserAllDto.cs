using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.DTOs
{
    public class UserAllDto
    {
        public int UsersCount { get; set; }

        public UserProductDto[] Users { get; set; }
    }
}
