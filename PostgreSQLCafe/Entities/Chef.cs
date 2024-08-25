namespace PostgreSQLCafe.Entities
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        // Navigation property for related social media accounts
        public ICollection<SocialMedia> SocialMedias { get; set; }
    }
}
