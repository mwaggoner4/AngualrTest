using System;
using System.Collections.Generic;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class FilmShowing
    {
        public int FilmShowingsId { get; set; }
        public int TheatreId { get; set; }
        public int FilmId { get; set; }
        public DateTime ShowDate { get; set; }
        public DateTime Showtime { get; set; }
        public int TicketsAvailable { get; set; }

        public virtual TheatreFilm Film { get; set; } = null!;
        public virtual Theatre Theatre { get; set; } = null!;
    }
}
