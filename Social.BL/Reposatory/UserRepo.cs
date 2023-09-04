namespace Social.BL.Reposatory
{
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext Db;
        public UserRepo(ApplicationDbContext Db)
        {
            this.Db = Db;       
        }
        public List<User> GetAllUsers()//return list of All users in Db
        {
            var usrers=Db.Users.Where(a=>a.IsDeleted==false).ToList();
            return usrers;
        }
    }
}
