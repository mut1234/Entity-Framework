namespace Update_Bulk_Delete_Bulk.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        public ICollection<Post> Posts { get; set; }

       // public List<PostTag> PostTags { get; set; }


    }
}
