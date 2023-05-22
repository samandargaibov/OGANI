namespace OganiMasterMVC.DataAccessLayer.Entities
{
    public class Blogs
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTime InsertDate { get; set; }

        public int Comment { get; set; }

        public string? ImageUrl { get; set; }
    }
}
