using SpotifyAPI.Web;

namespace BlazorApp1.Models {
    public class SpotifyModel {
        public string verifier = "";
        public string challenge = "";
        public string code = "";
        public string client_id = "923df0dfc15e4b3e9ebcf444a80f6d06";
        public string redirect_uri = "https://localhost:7149/spotify";

        public OAuthClient oAut = new OAuthClient();
        public SpotifyClient spotifyClient = null;

        public CurrentlyPlayingContext currentlyPlayingContext = null;
    }
}
