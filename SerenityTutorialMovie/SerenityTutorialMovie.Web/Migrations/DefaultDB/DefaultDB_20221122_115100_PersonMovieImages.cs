using FluentMigrator;
using System;

namespace SerenityTutorialMovie.Migrations.DefaultDB
{
    [Migration(20221122115100)]
    public class DefaultDB_20221122_115100_PersonMovieImages : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Person").InSchema("mov")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
        }
    }
}