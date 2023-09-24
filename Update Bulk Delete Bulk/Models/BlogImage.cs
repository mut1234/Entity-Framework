using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Update_Bulk_Delete_Bulk.Models
{
    public class BlogImage
    {
        public int Id { get; set; }

        public string Image { get; set; }

        [Required,MaxLength(250)]
        public string Caption { get; set; }

        public int BolgForeignKey { get; set; }

        //[ForeignKey("BolgForeignKey")]
        public Blog Blog { get; set; }
    }
}
