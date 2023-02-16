namespace SerenityTutorialMovie.Default {

    @Serenity.Decorators.registerClass()
    export class MovieCastEditDialog extends Common.GridEditorDialog<MovieCastRow> {
        protected getFormKey() { return MovieCastForm.formKey; }
       
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getNameProperty() { return MovieCastRow.nameProperty; }
        
        

        protected form: MovieCastForm;
        constructor() {
            super();
            this.form = new MovieCastForm(this.idPrefix);
        }
       

    }
}