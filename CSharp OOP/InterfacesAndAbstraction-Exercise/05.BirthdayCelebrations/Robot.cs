using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Robot : IIdentifiable
    {
        private string model;
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get => model; set => model = value; }
        public string Id { get; private set; }
    }
}
