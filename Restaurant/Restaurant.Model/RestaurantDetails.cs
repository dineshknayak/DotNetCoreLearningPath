namespace Restaurant.Model
{
    public class RestaurantDetails
    {
        public int ID { get; set; }
        public string RestaurantName { get; set; }
        public CuisineType Cuisine { get; set; }
    }

    public enum CuisineType
    {
        Indian,
        Italian,
        French,
        Chineese
    }
}