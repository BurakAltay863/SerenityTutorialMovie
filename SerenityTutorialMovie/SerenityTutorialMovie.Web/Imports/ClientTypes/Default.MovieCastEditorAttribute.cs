using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SerenityTutorialMovie.Default
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SerenityTutorialMovie.Default.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}

