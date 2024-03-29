﻿namespace SerenityTutorialMovie.Default {

    @Serenity.Decorators.registerClass()
    export class MovieCastDialog extends Common.GridEditorDialog<MovieCastRow> {
        protected getFormKey() { return MovieCastForm.formKey; }
        protected getNameProperty() { return MovieCastRow.nameProperty; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }


        protected form: MovieCastForm;
        constructor() {
            super();
            this.form = new MovieCastForm(this.idPrefix);
        }
       

    }
}