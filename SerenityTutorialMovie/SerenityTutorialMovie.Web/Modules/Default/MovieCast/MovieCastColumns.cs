
namespace SerenityTutorialMovie.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow), CheckNames = true)]
    public class MovieCastColumns
    {


        [EditLink, Width(220)]
        public string PersonFullname { get; set; }
        [EditLink, Width(150)]
        public string Character { get; set; }

    }
}