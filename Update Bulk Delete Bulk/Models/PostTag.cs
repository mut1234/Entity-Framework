using System.ComponentModel.DataAnnotations;

namespace Update_Bulk_Delete_Bulk.Models
{
    public class PostTag
    {
        public int postId { get; set; }
        public Post Post { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public DataType Addedon { get; set; }
    }
}
