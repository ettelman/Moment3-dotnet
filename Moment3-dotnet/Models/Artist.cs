﻿namespace Moment3_dotnet.Models
{
    public class Artist
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<Cd>? Cds { get; set; }
    }
}
