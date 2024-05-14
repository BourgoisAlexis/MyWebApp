namespace BlazorApp1.Models {
    public static class AppConst {
        //Colors
        public static string light = "#FFFBF5";

        public static string dark = "#2C1F20";

        public static string color = "#FD4556";
        public static string colorTint = "#FD7884";
        public static string colorShade = "#C93744";
        public static string colorTone = "#CD5f69";

        public static string colorSuperTone = "#7F6265";

        //Animation
        public static string duration = "350ms";

        public static string descriptionVersusPunch = "Versus punch is a game jam game created in 2019 with some friends of mine";
        public static string descriptionFemora = "Femora c'est pas ouf mais bon";
        public static string descriptionKatraBall = "Katra ball c'est casu";
        public static string descriptionKatraHeroes = "Katra heroes franchement c'était banger";

        public static string aboutMe = "Salut moi c'est Alexis je suis un dev Unity et j'adore les jeux vidéos parce que les jeux vidéos c'est super";

        public static string placeHolder = "<Place Holder>";

        public static HttpClient sharedClient = new() {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
        };

        public static SpotifyModel SpotifyModel = new SpotifyModel();

        public static bool loading = false;
    }
}
