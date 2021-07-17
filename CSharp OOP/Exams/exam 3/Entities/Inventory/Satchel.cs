﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory.Contracts
{
    public class Satchel : Bag
    {
        private const int capacity = 20;

        public Satchel() 
            : base(capacity)
        {
        }
    }
}
