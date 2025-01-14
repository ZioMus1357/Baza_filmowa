namespace BAZA_FILMOWA.Models
{

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public int Age_rating { get; set; }
        public int Movie_rating { get; set; }
        public string Genre { get; set; }
        public string Country_of_origin { get; set; }

    }
}


