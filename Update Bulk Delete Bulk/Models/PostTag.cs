using System;

namespace Update_Bulk_Delete_Bulk.Models
{
    public class PostTag
    {
        public int postId { get; set; }
        public Post Post { get; set; }

        public int TagId { get; set; }
        public Post Tag { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
