namespace Moment3_dotnet.Models
{
    public class Cd
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Artist? Artist { get; set; }
        public int ArtistId { get; set; }
    }
}
