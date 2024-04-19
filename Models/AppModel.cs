namespace BlazorApp1.Models {
    public static class AppModel {
        public static string light = "#eeeeee";

        public static string dark = "#393939";

        public static string color = "#255fe3";
        public static string colorTint = "#aabbe3";

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
