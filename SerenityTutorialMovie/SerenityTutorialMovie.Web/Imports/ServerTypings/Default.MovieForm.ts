namespace SerenityTutorialMovie.Default {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        PrimaryImage: Serenity.ImageUploadEditor;
        GalleryImages: Serenity.MultipleImageUploadEditor;
        Description: Serenity.TextAreaEditor;
        CastList: MovieCastEditor;
        Storyline: Serenity.TextAreaEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        GenreList: Serenity.LookupEditor;
        Runtime: Serenity.IntegerEditor;
        Kind: Serenity.EnumEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.MultipleImageUploadEditor;
                var w3 = s.TextAreaEditor;
                var w4 = MovieCastEditor;
                var w5 = s.IntegerEditor;
                var w6 = s.DateEditor;
                var w7 = s.LookupEditor;
                var w8 = s.EnumEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'PrimaryImage', w1,
                    'GalleryImages', w2,
                    'Description', w3,
                    'CastList', w4,
                    'Storyline', w3,
                    'Year', w5,
                    'ReleaseDate', w6,
                    'GenreList', w7,
                    'Runtime', w5,
                    'Kind', w8
                ]);
            }
        }
    }
}

