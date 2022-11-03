﻿namespace FastChicken.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public int ComboId { get; set; }

        public Combo Combo { get; set; }
    }
}
