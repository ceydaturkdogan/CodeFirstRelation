namespace CodeFirstRelation.Entities
{
    public class User
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public List<Post> Posts { get; set; }
    }
}
