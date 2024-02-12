namespace RestaurantApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Destination> Addresses { get; set; }
    }
}
