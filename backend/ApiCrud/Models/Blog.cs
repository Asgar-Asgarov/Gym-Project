namespace ApiCrud.Models
{
    public class Blog:BaseEntity
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public string? Author { get; set; }
         


        public BlogDetail? blogDetail { get; set; }
    }
}