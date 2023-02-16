

using Serenity.ComponentModel;
using SerenityTutorialMovie.Default.Entities;

namespace MovieTutorial.MovieDB.Columns
{
    [ColumnsScript("Default.PersonMovie")]
    [BasedOnRow(typeof(MovieCastRow))]
    public class PersonMovieColumns
    {
        [Width(220)]
        public string MovieTitle { get; set; }
        [Width(100)]
        public int MovieYear { get; set; }
        [Width(200)]
        public string Character { get; set; }
       
    }
}