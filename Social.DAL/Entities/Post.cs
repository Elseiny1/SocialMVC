namespace Social.DAL.Entities
{
    public class Post
    {
        //qolums
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "minimum lenth is 10")]
        public string body { get; set; }
        public bool IsDleted { get; set; }
        public DateTime PublishDate { get; set; }

        //Relations

        List<Comment> Comments { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
