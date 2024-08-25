namespace PostgreSQLCafe.Dto.ChefDto
{
    public class ResultChefWithSocialMediaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public List<string> SocialMediaLinks { get; set; } = new List<string>();
    }
}
