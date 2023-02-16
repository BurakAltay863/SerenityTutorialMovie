using FluentMigrator;

namespace SerenityTutorialMovie.Migrations.DefaultDB
{
    [Migration(20221114_183600)]
    public class DefaultDB_20221114_183600_GenreTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Genre").InSchema("mov")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("GenreId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId");
        }
    }
}

