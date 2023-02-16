
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


    [FormScript("Default.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow), CheckNames = true)]
    public class MovieCastForm
    {

        public int PersonId { get; set; }
        public string Character { get; set; }
    }
}