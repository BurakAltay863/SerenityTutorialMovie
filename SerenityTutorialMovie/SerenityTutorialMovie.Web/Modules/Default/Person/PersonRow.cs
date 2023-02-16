
namespace SerenityTutorialMovie.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using SerenityTutorialMovie.Default;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[mov].[Person]")]
    [DisplayName("Person"), InstanceName("Person")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript ("Default.Person")]
    public sealed class PersonRow : Row, IIdRow, INameRow
    {
        [DisplayName("Person Id"), Identity]
        public Int32? PersonId
        {
            get { return Fields.PersonId[this]; }
            set { Fields.PersonId[this] = value; }
        }

        [DisplayName("First Name"), Size(50), NotNull, QuickSearch]
        public String FirstName
        {
            get { return Fields.FirstName[this]; }
            set { Fields.FirstName[this] = value; }
        }

        [DisplayName("Lastname"), Size(50), NotNull]
        public String Lastname
        {
            get { return Fields.Lastname[this]; }
            set { Fields.Lastname[this] = value; }
        }
        [DisplayName("Full Name"),
         Expression("(t0.FirstName + ' ' + t0.Lastname)"), QuickSearch, NameProperty]
        public string Fullname
        {
            get => Fields.Fullname[this];
            set => Fields.Fullname[this] = value;
        }


        [DisplayName("Birth Date")]
        public DateTime? BirthDate
        {
            get { return Fields.BirthDate[this]; }
            set { Fields.BirthDate[this] = value; }
        }

        [DisplayName("Birth Place"), Size(100)]
        public String BirthPlace
        {
            get { return Fields.BirthPlace[this]; }
            set { Fields.BirthPlace[this] = value; }
        }

        [DisplayName("Gender")]
        public Gender? Gender
        {
            get => Fields.Gender[this];
            set => Fields.Gender[this] = value;
        }

        [DisplayName("Height")]
        public Int32? Height
        {
            get { return Fields.Height[this]; }
            set { Fields.Height[this] = value; }
        }

        [DisplayName("Primary Image"), Size(100),
         ImageUploadEditor(FilenameFormat = "Person/PrimaryImage/~")]
        public string PrimaryImage
        {
            get => Fields.PrimaryImage[this];
            set => Fields.PrimaryImage[this] = value;
        }

        [DisplayName("Gallery Images"),
         MultipleImageUploadEditor(FilenameFormat = "Person/GalleryImages/~")]
        public string GalleryImages
        {
            get => Fields.GalleryImages[this];
            set => Fields.GalleryImages[this] = value;
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.PersonId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Fullname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PersonRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PersonId;
            public StringField FirstName;
            public StringField Lastname;
            public DateTimeField BirthDate;
            public StringField BirthPlace;
            public StringField Fullname;
            public Int32Field Height;
            public EnumField<Gender>Gender;
            public StringField PrimaryImage;
            public StringField GalleryImages;




        }
    }
}
