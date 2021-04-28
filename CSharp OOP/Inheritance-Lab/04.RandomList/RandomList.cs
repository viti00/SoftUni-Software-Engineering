﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }


        public string RandomString()
        {
            string elementToRemove =  this[random.Next(0, this.Count)];
            this.Remove(elementToRemove);
            return elementToRemove;
        }
    }
}
