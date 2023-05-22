using OganiMasterMVC.DataAccessLayer.Entities;

namespace OganiMasterMVC.ViewModels
{
    public class HomeViewModel
    {
        public List<Categories>? Categories { get; set; }
        public List<Products>? Products { get; set; }
        public List<Banners>? Banners { get; set; }
        public List<SliderCategories>? SliderCategories { get; set; }
        public List<Blogs>? Blogs { get; set; }
        public List<FeaturedCategories>? FeaturedCategories { get; set; }
    }
}
