namespace PostgreSQLCafe.Entities
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string SocialMediaUrl { get; set; }
        public string SocialMediaSite { get; set; }

        // Foreign key to reference the Chef
        public int ChefId { get; set; }
        public Chef Chef { get; set; } // Navigation property to the Chef
    }
}
