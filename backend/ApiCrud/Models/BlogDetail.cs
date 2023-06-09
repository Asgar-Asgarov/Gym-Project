namespace ApiCrud.Models
{
    public class BlogDetail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }



        public int BlogId { get; set; }
        public Blog? blog { get; set; }

    }
}