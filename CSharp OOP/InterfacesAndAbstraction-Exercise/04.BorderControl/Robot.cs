using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string model, string id)
        {
            Model = Model;
            Id = id;
        }

        public string Model { get => model; set => model = value; }
        public string Id { get; private set; }
    }
}
