
namespace SerenityTutorialMovie.Default {
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor
        extends Common.GridEditorBase<MovieCastRow>{
        protected getColumnsKey() { return "Default.MovieCast"; }
        protected getLocalTextDbPrefix() { return MovieCastRow.localTextPrefix; }
        protected getDialogType() { return MovieCastEditDialog; }
        constructor(container: JQuery) {
            super(container);
        }
        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: MovieCastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.PersonFullname = PersonRow.getLookup()
                .itemById[row.PersonId].Fullname;

            return true;
        }
    }
}