﻿namespace Update_Bulk_Delete_Bulk.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public ICollection<Tag> Tags { get; set; }// without 3rd entity



        public List<PostTag> PostTags { get; set; }

    }
}
