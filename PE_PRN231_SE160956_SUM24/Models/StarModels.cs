using BussinessObject.Models;
using System.Text.Json.Serialization;

namespace PE_PRN231_SE160956_SUM24.Models
{
    public class StarModels
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public bool? Male { get; set; }
        public string? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string? DobString { get; set; }

        public string? Description { get; set; }

        public string? Nationality { get; set; }
    }
    public class MovieModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public DateTime? ReleaseDate { get; set; }

        public string? Description { get; set; }

        public string Language { get; set; } = null!;

        public int? ProducerId { get; set; }

        public int? DirectorId { get; set; }

        public virtual Director? Director { get; set; }

        public virtual Producer? Producer { get; set; }

        public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();

        public virtual ICollection<Star> Stars { get; set; } = new List<Star>();
    }
    public class StartModelIncludeMovie : StarModels
    {
        [JsonPropertyOrder(2)]
        public List<MovieModel> Movies { get; set; }
    }
}
