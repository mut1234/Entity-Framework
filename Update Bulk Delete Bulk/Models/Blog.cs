using System.ComponentModel.DataAnnotations;

namespace Update_Bulk_Delete_Bulk.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required,MaxLength(1000)]
        public string Url { get; set; }

        public BlogImage blogImage { get; set; }


    }
}
