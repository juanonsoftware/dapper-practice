﻿using System;

namespace DapperModel
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Model { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}
