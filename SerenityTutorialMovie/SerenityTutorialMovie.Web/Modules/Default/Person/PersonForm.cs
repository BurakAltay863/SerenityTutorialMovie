
namespace SerenityTutorialMovie.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Person")]
    [BasedOnRow(typeof(Entities.PersonRow), CheckNames = true)]
    public class PersonForm
    {
        [Tab("Person")]
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string PrimaryImage { get; set; }
        public string GalleryImages { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
  
    }
}