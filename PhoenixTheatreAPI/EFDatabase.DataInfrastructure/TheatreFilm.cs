using System;
using System.Collections.Generic;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class TheatreFilm
    {
        public TheatreFilm()
        {
            FilmShowings = new HashSet<FilmShowing>();
        }

        public int FilmId { get; set; }
        public string FilmName { get; set; } = null!;
        public string FilmRating { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string FilmDescription { get; set; } = null!;
        public int FilmDuration { get; set; }
        public string ImageUrl { get; set; } = null!;

        public virtual ICollection<FilmShowing> FilmShowings { get; set; }
    }
}
