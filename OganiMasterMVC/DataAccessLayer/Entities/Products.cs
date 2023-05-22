namespace OganiMasterMVC.DataAccessLayer.Entities
{
    public class Products
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Price { get; set; }

        public string? ImageUrl { get; set; }

        public int? CategoryId { get; set; }

        public Categories? Category { get; set; }

        public int? FeaturedCategoryId { get; set; }

        public FeaturedCategories? FeaturedCategory { get; set; }
    }
}
