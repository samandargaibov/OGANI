namespace OganiMasterMVC.DataAccessLayer.Entities
{
    public class FeaturedCategories
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<Products>? Products { get; set; }
    }
}
