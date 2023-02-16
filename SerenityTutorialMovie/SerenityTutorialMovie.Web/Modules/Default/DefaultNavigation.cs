using Serenity.Navigation;
using MyPages = SerenityTutorialMovie.Default.Pages;
[assembly: NavigationMenu(1000,"Movie Database", icon:"fa-bullhorn")]
[assembly: NavigationLink(1001, "Movie Database/Movie", typeof(MyPages.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(1002, "Movie Database/Genre", typeof(MyPages.GenreController), icon: "fa-thumb-tack")]
[assembly: NavigationLink(1003, "Movie Database/Person", typeof(MyPages.PersonController), icon: "fa-users")]