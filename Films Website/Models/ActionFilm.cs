using System;
using System.Collections.Generic;

namespace NewFilms.Models;

public partial class ActionFilm
{
    public short FilmId { get; set; }

    public string FilmName { get; set; } = null!;

    public string Director { get; set; } = null!;

    public double Imdb { get; set; }

    public DateTime ReleasedDate { get; set; }

    public string LeadActor { get; set; } = null!;

    public string Genre { get; set; } = null!;
}
