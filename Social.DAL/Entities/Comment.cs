



namespace Social.DAL.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "minimum lenth is 10")]
        public string body { get; set; }
        public bool IsDleted { get; set; }
        public DateTime PublishDate { get; set; }
        //Relations
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
