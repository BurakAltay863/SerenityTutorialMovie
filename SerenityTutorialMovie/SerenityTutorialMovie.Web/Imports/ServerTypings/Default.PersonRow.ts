namespace SerenityTutorialMovie.Default {
    export interface PersonRow {
        PersonId?: number;
        FirstName?: string;
        Lastname?: string;
        BirthDate?: string;
        BirthPlace?: string;
        Fullname?: string;
        Height?: number;
        Gender?: Gender;
        PrimaryImage?: string;
        GalleryImages?: string;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'Default.Person';
        export const lookupKey = 'Default.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('Default.Person');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            PersonId = "PersonId",
            FirstName = "FirstName",
            Lastname = "Lastname",
            BirthDate = "BirthDate",
            BirthPlace = "BirthPlace",
            Fullname = "Fullname",
            Height = "Height",
            Gender = "Gender",
            PrimaryImage = "PrimaryImage",
            GalleryImages = "GalleryImages"
        }
    }
}

