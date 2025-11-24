namespace ContemporaryFinal.Models
{
    public class FavoriteMovies
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
    }
}
