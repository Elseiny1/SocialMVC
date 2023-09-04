namespace Social.DAL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }

        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
