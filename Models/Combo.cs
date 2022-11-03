namespace FastChicken.Models
{
    public class Combo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; } 

        public int OrderId { get; set; }    
        public Order Order { get; set; }    
    }
}
