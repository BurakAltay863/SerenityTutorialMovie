
namespace SerenityTutorialMovie.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using SerenityTutorialMovie.Default.Entities;
 

    [FormScript("Default.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieForm
    {
        public String Title { get; set; }
        public string PrimaryImage { get; set; }
        public string GalleryImages { get; set; }
        [TextAreaEditor(Rows = 3)]
        public String Description { get; set; }
        [MovieCastEditor, IgnoreName]
        public List<MovieCastRow> CastList { get; set; }

        [TextAreaEditor(Rows = 8)]
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<int> GenreList { get; set; }
        public Int32 Runtime { get; set; }
        public MovieKind Kind { get; set; }
        

    }
}