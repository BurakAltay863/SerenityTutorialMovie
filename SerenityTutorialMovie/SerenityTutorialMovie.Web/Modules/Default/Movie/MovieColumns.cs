
namespace SerenityTutorialMovie.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        [Width(100)]
        public Int32 Year { get; set; }

        [Width(100), GenreListFormatter,QuickFilter]
        public ListField<Int32> GenreList { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Width(100), QuickFilter]
        public MovieKind Kind { get; set; }
        [DisplayName("Runtime is Minutes"), Width(150),AlignRight]
        public Int32 Runtime { get; set; }
        

    }
}